using DAL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace App
{
    public partial class fManager : Form
    {

        #region Delegate

        private Action reset;
        private Account acc;
        public Action Reset { get => reset; set => reset = value; }

        #endregion


        bool moving;
        int x, y;

        public fManager(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            LoadTable();
            LoadCategory();
            LoadcbTables();
            DecentralizationAndLoadName();
            ImageLoading();
        }

      



        #region Method


        /// <summary>
        /// Làm mới dữ liệu khi xóa đồ uống trong mục Quản lý
        /// </summary>
        /// <param name="TableID"></param>
        void RefreshTable(int TableID)
        {
            LoadBill(TableID);
            if(BillDAL.Instance.GetBillID(TableID) == -1)
            {
                TableDAL.Instance.UpdateStatusTable(TableID, "Trống");
            }
            LoadTable();
            LoadcbTables();
        }


        void LoadImageDrinkButton(ImageList piclist)
        {
            int i = 0;
            int count = piclist.Images.Count;
            foreach (Button btn in flpDrink.Controls)
            {
                btn.ImageList = piclist;
                btn.ImageIndex = i;
                btn.Tag = i;
                btn.ImageAlign = ContentAlignment.TopCenter;
                if(i < count - 1)
                i++;
            }
        }

        void DecentralizationAndLoadName()
        {
            AdminToolStripMenuItem.Enabled = acc.AccountType == "ADMIN" ? true : false;
            tooltxtInfor.Text = "Xin chào!  " + $"{acc.Displayname}";
        }


        void ImageLoading()
        {
            if (File.Exists("Image.txt") && File.Exists("Index.txt"))
            {
                string[] imagePaths = File.ReadAllLines("Image.txt");
                string[] index = File.ReadAllLines("Index.txt");
                int i = 0;
                foreach (string filePath in imagePaths)
                {
                    if (File.Exists(filePath))  // Kiểm tra xem file có tồn tại không
                    {
                        if(filePath.Contains("4"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il4.Images.Add(image);
                            il4.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("5"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il5.Images.Add(image);
                            il5.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("7"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il7.Images.Add(image);
                            il7.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("10"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il10.Images.Add(image);
                            il10.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("11"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il11.Images.Add(image);
                            il11.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("12"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il12.Images.Add(image);
                            il12.Images[int.Parse(index[i])] = image;
                        }
                        else if (filePath.Contains("13"))
                        {
                            Image image = Image.FromFile(filePath);
                            image = new Bitmap(image, new Size(140, 95));
                            il13.Images.Add(image);
                            il13.Images[int.Parse(index[i])] = image;
                        }
                        i++;
                    }
                }
            }
        }

        void LoadcbTables()
        {
            List<Table> table = TableDAL.Instance.LoadTable();
            cbTables.DataSource = table;
            cbTables.DisplayMember = "TableName";
        }


        void LoadTable()
        {
            flpTables.Controls.Clear();
            List<Table> Tables = TableDAL.Instance.LoadTable();
            foreach (Table table in Tables)
            {
                Button btn = new Button()
                {
                    Text = $"{table.TableName}\nTrạng thái: {table.Status}",
                    Size = new Size(TableDAL.TableWidth, TableDAL.TableHeigh),
                    Font = new Font("Microsoft Sans Serif", 10 ,FontStyle.Regular),
                };
                btn.Cursor = Cursors.Hand;
                btn.Tag = table;
                btn.Click += Btn_Click;
                switch (table.Status)
                {
                    case "Có khách":
                        btn.BackColor = Color.Lime;
                        break;
                    case "Khách đặt trước":
                        btn.BackColor = Color.Salmon;
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }
                flpTables.Controls.Add(btn);
            }
        }


        void LoadCategory()
        {
            cbCategory.DataSource = CategoryDAL.Instance.LoadCategory();
            cbCategory.DisplayMember = "Name";
        }



        /// <summary>
        /// Tải danh sách đồ uống dựa theo mã danh mục 
        /// </summary>
        /// <param name="id"></param>
        void LoadDrink(int id)
        {
            flpDrink.Controls.Clear();

            var Drinks = DrinkDAL.Instance.LoadDrink(id);
            foreach (Drink drink in Drinks)
            {
                Button button = new Button()
                {
                    Text = drink.Name + $"  | Giá:  {drink.Price/1000}K",
                    Size = new Size(145, 167),
                    Font = new Font("Segoe UI", 12.1f, FontStyle.Regular),
                    TextAlign = ContentAlignment.BottomCenter,
                    BackColor = Color.WhiteSmoke,
                    Cursor = Cursors.Hand
                };
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                var item = new ToolStripButton() { Text = "Thêm hình ảnh...", Width = 100, Height = 26};
                item.Image = new Bitmap(GUI.Properties.Resources.picture_frame, new Size(26, 26));
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                item.ImageAlign = ContentAlignment.MiddleLeft;
                item.Click += Item_Click;
                item.Tag = button;

                if (acc.AccountType == "ADMIN")
                {
                    button.MouseDown += Button_MouseDown;
                    contextMenuStrip.Items.Add(item);
                }

                contextMenuStrip.ShowImageMargin = true;
                contextMenuStrip.Tag = drink;
                button.ContextMenuStrip = contextMenuStrip;

                button.Click += Button_Click;
                flpDrink.Controls.Add(button);
            }
            switch (id)
            {
                case 4:
                    LoadImageDrinkButton(il4);
                    break;
                case 5:
                    LoadImageDrinkButton(il5);
                    break;
                case 7:
                    LoadImageDrinkButton(il7);
                    break;
                case 10:
                    LoadImageDrinkButton(il10);
                    break;
                case 11:
                    LoadImageDrinkButton(il11);
                    break;
                case 12:
                    LoadImageDrinkButton(il12);
                    break;
                case 13:
                    LoadImageDrinkButton(il13);
                    break;
            }
            ImageLoading();
        }




        /// <summary>
        /// Tải lên danh sách hóa đơn của khách hàng mỗi khi nhấn vào từng bàn
        /// </summary>
        /// <param name="id"></param> id của bàn chứa hóa đơn đó
        void LoadBill(int id)
        {
            lvBills.Items.Clear();
            numDiscount.Value = 0;
            List<BillDetail> Bills = BillDetailDAL.Instance.LoadBill(id);

            //Chỉnh thành đơn vị tiền tệ của Việt Nam
            CultureInfo cul = new CultureInfo("vi-VN");
            double sum = 0;
            foreach (BillDetail bill in Bills)
            {
                sum += bill.Total;
                ListViewItem item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.Name);
                item.SubItems.Add(bill.Count.ToString());
                item.SubItems.Add(bill.Price.ToString("n0", cul));
                item.SubItems.Add(bill.Total.ToString("n0", cul));
                lvBills.Items.Add(item);
            }
            txtPriceSum.Text = sum.ToString("c0", cul);
        }


        string GetTotalBill(int id)
        {
            List<BillDetail> Bills = BillDetailDAL.Instance.LoadBill(id);

            //Chỉnh thành đơn vị tiền tệ của Việt Nam
            CultureInfo cul = new CultureInfo("vi-VN");
            double sum = 0;
            foreach (BillDetail bill in Bills)
            {
                sum += bill.Total;
            }
            return sum.ToString("C0", cul);
        }


        double CurrentPrice()
        {
            double sum = 0;
            foreach (ListViewItem item in lvBills.Items)
            {
                string tmp = item.SubItems[4].Text;
                tmp = tmp.Replace(".", "");
                sum += double.Parse(tmp);
            }
            return sum;
        }


        #endregion




        #region Event
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInformation inf = new fInformation(acc);

            //Gọi event thông qua đối tượng được khởi tạo trong form chính, gán các method cho event để thực thi
            inf.Updatedt += Inf_Updatedt;

            inf.ShowDialog();
        }


        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (e.Button == MouseButtons.Right)
            {
                // Hiển thị ContextMenuStrip tại vị trí chuột
                btn.ContextMenuStrip.Show(btn, e.Location);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btnAddDrink.Tag = btn.ContextMenuStrip.Tag as Drink;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Chọn hình ảnh";
            ToolStripButton tbtn = sender as ToolStripButton;
            Button button = tbtn.Tag as Button;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Image img = Image.FromFile(path);
                button.Image = new Bitmap(img, new Size(140, 95));
                File.AppendAllLines("Image.txt", new string[] { path }); 
                File.AppendAllLines("Index.txt", new string[] { button.Tag.ToString() });
            }
        }


        /// <summary>
        /// Event thực hiện chức năng cập nhật thông tin người dùng khi có thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inf_Updatedt(object sender, AccountEvent e)
        {
            acc = e.Acc;
            tooltxtInfor.Text = "Xin chào!  " + acc.Displayname;
        }


        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin ad = new fAdmin();
            ad.acc = acc;

            //Gán phương thức cho Delegate để thực thi 
            ad.TableRefresh = RefreshTable;
            ad.DrinkListRefresh = LoadDrink;
            ad.ReLoadTable = LoadTable;
            ad.ReLoadTable += LoadcbTables;
            ad.ReLoadCategory = LoadCategory;
            ad.ReLoadCategory += LoadTable;

            ad.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePass newpass = new fChangePass(acc);
            newpass.Restart = Close;
            newpass.ShowDialog();
        }


        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đăng xuất tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reset.Invoke();
                this.Close();
            }
        }

        private void toolStripPrint_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(BillDAL.Instance.GetBillID(table.ID) == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if(txtClient.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fBillReport report = new fBillReport(table, txtPriceSum.Text, txtClient.Text);
            report.PriceFormatter = GetTotalBill;
            report.ShowDialog();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int id = (b.Tag as Table).ID;
            //Lưu dữ liệu của đối tượng Table được lưu từ thuộc tính Tag của mỗi Button b
            lvBills.Tag = b.Tag;
            LoadBill(id);
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            double Pricesum = CurrentPrice();
            Pricesum -= Pricesum * ((double)numDiscount.Value/100);
            CultureInfo cul = new CultureInfo("vi-VN");
            txtPriceSum.Text = Pricesum.ToString("c0", cul);
        }



        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cate = cbCategory.SelectedValue as Category;
            int id = cate.Id;
            LoadDrink(id);
        }


        //Thêm đồ
        //Quy ước: đối với mỗi bàn chỉ được tồn tại nhiều nhất 1 hóa đơn chưa thanh toán
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (numCount.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng đồ cần thêm/bớt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Table table = lvBills.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //nếu bàn đó không có bill nào chưa thanh toán sẽ trả về id bill = -1
            int idBill = BillDAL.Instance.GetBillID(table.ID);
            int idDrink = (btn.Tag as Drink).Id;
            if (idBill == -1)
            {
                BillDAL.Instance.AddBill(table.ID, (int)numCount.Value);
                BillInforDAL.Instance.AddOrUpdateBillInfor(BillDAL.Instance.CreateNewIDBill(), idDrink, (int)numCount.Value);

                if (numCount.Value > 0)
                    TableDAL.Instance.UpdateStatusTable(table.ID, "Có khách");
            }
            else
            {
                BillInforDAL.Instance.AddOrUpdateBillInfor(idBill, idDrink, (int)numCount.Value);

                int Cur_idBill = BillDAL.Instance.GetBillID(table.ID);

                if (Cur_idBill == -1) TableDAL.Instance.UpdateStatusTable(table.ID, "Trống");

            }
            LoadBill(table.ID);
            LoadTable();
        }



        //Thanh toán! Cập nhật trạng thái của bill về 1: "Đã thanh toán"
        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idbill = BillDAL.Instance.GetBillID(table.ID);
            if (idbill != -1)
            {
                DialogResult r = MessageBox.Show($"Xác nhận thanh toán cho {table.TableName}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    MessageBox.Show("Thanh toán thành công!\nCảm ơn bạn đã sử dụng dịch vụ (≧∇≦)ﾉ", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string tmp = txtPriceSum.Text.Replace("₫", "");
                    tmp = tmp.Replace(".", "");

                    BillDAL.Instance.UpdateBill(idbill, table.ID, (int)numDiscount.Value, double.Parse(tmp));
                    LoadBill(table.ID);
                    TableDAL.Instance.UpdateStatusTable(table.ID, "Trống");
                    LoadTable();
                }
            }
        }


        //Chuyển bàn
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Table tableL = lvBills.Tag as Table;
            Table tableR = cbTables.SelectedItem as Table;
            if (tableL == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int l = tableL.ID;
            int r = tableR.ID;

            if (BillDAL.Instance.GetBillID(l) == -1 && BillDAL.Instance.GetBillID(r) == -1)
            {
                MessageBox.Show("Không thể thực hiện chuyển bàn khi không có dữ liệu hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn chuyển từ {tableL.TableName} sang {tableR.TableName}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TableDAL.Instance.SwapTable(l, r);
                LoadTable();
                LoadBill(l);
            }
        }


        //Gộp bàn
        private void btnMerge_Click(object sender, EventArgs e)
        {
            Table tableL = lvBills.Tag as Table;
            Table tableR = cbTables.SelectedItem as Table;
            if (tableL == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int l = tableL.ID;
            int r = tableR.ID;

            if (BillDAL.Instance.GetBillID(l) == -1 || BillDAL.Instance.GetBillID(r) == -1)
            {
                MessageBox.Show("Không thể gộp bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show($"Bạn có chắc muốn gộp {tableL.TableName} vào {tableR.TableName}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TableDAL.Instance.MergeTable(l, r);
                LoadTable();
                LoadBill(l);
            }
        }


        private void btnTableregister_Click(object sender, EventArgs e)
        {
            Table table = lvBills.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TableDAL.Instance.UpdateStatusTable(table.ID, "Khách đặt trước");
            LoadTable();
        }


        private void thêmbớtĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddDrink.PerformClick();
        }


        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPay.PerformClick();
        }
        

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSwitch.PerformClick();
        }


        private void fManager_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            //Lưu tọa độ hiện tại của con trỏ
            x = e.X;
            y = e.Y;
        }

        private void fManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                //Tham số truyền vào: Khoảng cách từ vị trí trước đó của con trỏ đến vị trí hiện tại
                SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void fManager_DoubleClick(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStockManager stock = new fStockManager(acc);
            this.Hide();
            stock.ShowDialog();
            this.Show();
        }

        private void fManager_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }


        #endregion


    }
}
