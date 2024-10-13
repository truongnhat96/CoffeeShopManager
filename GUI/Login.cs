using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fLogin : Form
    {
        Account acc;
        public fLogin()
        {
            InitializeComponent();
            InitializePlaceholders();
        }

        #region Method

        void ResetDataLogin()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        void InitializePlaceholders()
        {
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "Username";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "Password";

            txtUsername.Enter += RemovePlaceholderText;
            txtUsername.Leave += SetPlaceholderText;
            txtUsername.TextChanged += RemovePlaceholderTextOnTextChanged;

            txtPassword.Enter += RemovePlaceholderText;
            txtPassword.Leave += SetPlaceholderText;
            txtPassword.TextChanged += RemovePlaceholderTextOnTextChanged;

        }

        void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Username" || textBox.Text == "Password")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == txtPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        void SetPlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtUsername)
                {
                    textBox.Text = "Username";
                }
                else if (textBox == txtPassword)
                {
                    textBox.Text = "Password";
                    textBox.UseSystemPasswordChar = false;
                }
                textBox.ForeColor = Color.Gray;
            }
        }

        void RemovePlaceholderTextOnTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text != "Username" && textBox.Text != "Password")
            {
                textBox.ForeColor = Color.Black;
                if (textBox == txtPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        #endregion

        #region Event

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.Login(txtUsername.Text, txtPassword.Text))
            {
                acc = AccountDAL.Instance.LoadAccount(txtUsername.Text, txtPassword.Text);
                fManager manager = new fManager(acc);
                btnLogin.Visible = false;
                picLoad.Visible = true;

                await Task.Run(() =>
                {
                    return Task.Delay(3500);
                });

                this.Hide();
                manager.Reset = ResetDataLogin;
                notiLoginsucess.ShowBalloonTip(5500);
                manager.ShowDialog();
                this.Show();
                btnLogin.Visible = true;
                picLoad.Visible = false;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password" || txtPassword.Text == "") return;
            if (chkViewPass.Checked) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            InitializePlaceholders();
        }

        #endregion


    }
}
