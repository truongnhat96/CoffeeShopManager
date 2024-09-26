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
    public partial class fViewSupplier : Form
    {
        public fViewSupplier()
        {
            InitializeComponent();
        }

        private void ViewSupplier_Load(object sender, EventArgs e)
        {
            dtgvSupplier.DataSource = SupplierDAL.Instance.LoadSupplier();
        }
    }
}
