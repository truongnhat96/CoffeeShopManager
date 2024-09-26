using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fSuppliersManage : Form
    {
        BindingSource SupplierSource = new BindingSource();

        Action productAct;

        public Action ProductAct { get => productAct; set => productAct = value; }

        public fSuppliersManage()
        {
            InitializeComponent();
            Loading();

        }

        void Loading()
        {
            SupplierSource.DataSource = SupplierDAL.Instance.LoadSupplier();
            dtgvSuppliers.DataSource = SupplierSource;
            AddBinding();
        }

        void AddBinding()
        {
            txtCompanyname.DataBindings.Add(new Binding("Text", dtgvSuppliers.DataSource, "Tên công ty", true, DataSourceUpdateMode.Never));
            txtPhonenumber.DataBindings.Add(new Binding("Text", dtgvSuppliers.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvSuppliers.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));


        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            SupplierSource.DataSource = SupplierDAL.Instance.LoadSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtCompanyname.Text;
            string phone = txtPhonenumber.Text;
            string address = txtAddress.Text;
            address = address == "" ? null : address;
            if (name == "" || phone == "")
            {
                MessageBox.Show("Tên công ty và số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(SupplierDAL.Instance.InsertSupplier(name, phone, address) > 0)
            {
                MessageBox.Show("Đã thêm thành công!", "Thông tin nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Không thể thêm nhà cung cấp (Tên đã tồn tại, dữ liệu không hợp lệ...)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SupplierSource.DataSource = SupplierDAL.Instance.SearchingSupplier(txtSearch.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtCompanyname.Text;
            string phone = txtPhonenumber.Text;
            string address = txtAddress.Text;
            if (name == "" || phone == "")
            {
                MessageBox.Show("Tên công ty và số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SupplierDAL.Instance.EditSupplier(name, phone, address) > 0)
            {
                MessageBox.Show("Đã sửa thành công!", "Thông tin nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Không thể sửa tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtCompanyname.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SupplierDAL.Instance.DeleteSupplier(name) > 0)
            {
                MessageBox.Show("Đã xóa thành công!", "Thông tin nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset.PerformClick();
                productAct.Invoke();
            }
            else
            {
                MessageBox.Show("Không thể xóa nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
