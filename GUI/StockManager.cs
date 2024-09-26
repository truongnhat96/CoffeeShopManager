using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStockManager : Form
    {
        bool move;
        int x, y;
        Account acc;

        CultureInfo cul = new CultureInfo("vi-VN");

        BindingSource StockSource = new BindingSource();

        public fStockManager(Account account)
        {
            InitializeComponent();
            this.acc = account;
            Loading();
        }

        void ProductLoading()
        {
            StockSource.DataSource = StockDAL.Instance.LoadProduct();
        }

        void Loading()
        {
            ProductLoading();
            dtgvProducts.DataSource = StockSource;
            AddBinding();
            panel1.Enabled = acc.AccountType == "ADMIN" ? true : false;
            lblAdmin.Visible = acc.AccountType == "ADMIN" ? false : true;
            lblNotifyadm.Visible = acc.AccountType == "ADMIN" ? true : false;
        }

        void AddBinding()
        {
            txtProductname.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Tên sản phẩm", true, DataSourceUpdateMode.Never));
            numCount.DataBindings.Add(new Binding("Value", dtgvProducts.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            txtUnit.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Đơn vị tính", true, DataSourceUpdateMode.Never));
            numPrice.DataBindings.Add(new Binding("Value", dtgvProducts.DataSource, "Giá tiền", true, DataSourceUpdateMode.Never));
            dtpDateimport.DataBindings.Add(new Binding("Value", dtgvProducts.DataSource, "Ngày nhập hàng", true, DataSourceUpdateMode.Never));
            txtSuppliername.DataBindings.Add(new Binding("Text", dtgvProducts.DataSource, "Nhà cung cấp", true, DataSourceUpdateMode.Never));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fStockManager_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void fStockManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            fSuppliersManage supplier = new fSuppliersManage();
            supplier.ProductAct = ProductLoading;
            supplier.ShowDialog();
        }

        private void lblSupplierView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fViewSupplier Vsupplier = new fViewSupplier();
            Vsupplier.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string namepro = txtProductname.Text;
            string namesupplier = txtSuppliername.Text;
            int count = (int)numCount.Value;
            string unit = txtUnit.Text;
            double price = (double)numPrice.Value;
            DateTime dateimport = dtpDateimport.Value;
            if(namepro == "" || namesupplier == "" || count == 0 || unit == "" || price == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StockDAL.Instance.InsertProduct(namepro, count, unit, price, dateimport, namesupplier, acc.Username) > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductLoading();
                txtTotal.Text = (price * count).ToString("c0", cul);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại\nVui lòng kiểm tra kỹ thông tin trước khi nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            double price = (double)numPrice.Value;
            int count = (int)numCount.Value;
            txtTotal.Text = (price * count).ToString("c0", cul);
        }

        private void btnEditproduct_Click(object sender, EventArgs e)
        {
            string namepro = txtProductname.Text;
            string namesupplier = txtSuppliername.Text;
            int count = (int)numCount.Value;
            string unit = txtUnit.Text;
            double price = (double)numPrice.Value;
            DateTime dateimport = dtpDateimport.Value;
            if (namepro == "" || namesupplier == "" || count == 0 || unit == "" || price == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (StockDAL.Instance.EditProduct(namepro, count, unit, price, dateimport, namesupplier) > 0)
            {
                MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductLoading();
                txtTotal.Text = (price * count).ToString("c0", cul);
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại\nKhông thể sửa tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveproduct_Click(object sender, EventArgs e)
        {
            string namesupplier = txtSuppliername.Text;
            if (namesupplier == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           if(MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?","Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (StockDAL.Instance.DeleteProduct(namesupplier) > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductLoading();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHistoryImport_Click(object sender, EventArgs e)
        {
            fImportHistory history = new fImportHistory();
            history.ShowDialog();
        }

        private void fStockManager_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X; 
            y = e.Y;
        }
    }
}
