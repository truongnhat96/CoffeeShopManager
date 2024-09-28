using DAL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VietQRHelper;

namespace GUI
{
    public partial class fBillReport : Form
    {
        Table table;
        string totalprice;
        string clientName;
        //Delegate lấy dữ liệu từ form chính về form con
        Func<int, string> priceFormatter;
        public Func<int, string> PriceFormatter { get => priceFormatter; set => priceFormatter = value; }

        Image QRCode()
        {
            var qrPay = QRPay.InitVietQR(
               bankBin: BankApp.BanksObject[BankKey.BIDV].bin,
               bankNumber: "45010006617116", // Số tài khoản
               amount: totalprice, // Số tiền
               purpose: $"Thanh toán QR cho {table.TableName}"  // Nội dung chuyển tiền,
             );
            string content = qrPay.Build();

            return QRCodeHelper.TaoVietQRCodeImage(content);
        }

        public fBillReport(Table table, string totalprice, string clientName)
        {
            InitializeComponent();
            this.table = table;
            this.totalprice = totalprice;
            this.totalprice = totalprice.Replace(".", ",");
            this.clientName = clientName;
        }

        private byte[] ConvertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void BillReport_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu từ dataset vào Report
            ReportDataSource report = new ReportDataSource("ExtractBill", BillDetailDAL.Instance.BillDetalList(table.ID));
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(report);
            byte[] imageByte = ConvertImageToByteArray(QRCode());


            #region Parameter
            ReportParameter para1 = new ReportParameter("PriceParam", totalprice);
            ReportParameter para2 = new ReportParameter("TableName", table.TableName);
            ReportParameter para3 = new ReportParameter("CurTotal", priceFormatter.Invoke(table.ID));
            ReportParameter para4 = new ReportParameter("TimeIn", BillDetailDAL.Instance.GetBillDate(table.ID).ToLongTimeString());
            ReportParameter para5 = new ReportParameter("DateIn", BillDetailDAL.Instance.GetBillDate(table.ID).ToLongDateString());
            ReportParameter para6 = new ReportParameter("ImageQRcode", Convert.ToBase64String(imageByte));
            ReportParameter para7 = new ReportParameter("Client", clientName);
            #endregion

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {para1, para2, para3, para4, para5, para6, para7 });

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
