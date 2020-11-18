using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class FormAdminPage : Form
    {
        public FormAdminPage(string Full_name)
        {
            InitializeComponent();
            this.labelName.Text = Full_name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuMakanan_Click(object sender, EventArgs e)
        {
            var form = new FormEditMenu();
            form.ShowDialog();
        }

        private void btnBillCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormBill();
            form.ShowDialog();
        }

        private void btnLaporanSales_Click(object sender, EventArgs e)
        {
            var form = new FormPenjualan();
            form.ShowDialog();
        }
    }
}
