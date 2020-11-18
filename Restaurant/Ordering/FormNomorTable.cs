using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering
{
    public partial class FormNomorTable : Form
    {
        public FormNomorTable()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxNomor.Text != "")
            {
                var form = new FormOrdering(comboBoxNomor.Text);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Nomor Table Terlebih Dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
