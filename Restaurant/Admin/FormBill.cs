using Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");

        private void FormBill_Load(object sender, EventArgs e)
        {
            GetBillRecord();
        }

        private void GetBillRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Bill", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            BilldataGridView.DataSource = dt;
        }

        private void BilldataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblBillid.Text = BilldataGridView.Rows[e.RowIndex].Cells["Bill_ID"].FormattedValue.ToString();
            this.lblDate.Text = BilldataGridView.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
            this.lblOrderid.Text = BilldataGridView.Rows[e.RowIndex].Cells["Order_ID"].FormattedValue.ToString();
            this.lblNomormeja.Text = BilldataGridView.Rows[e.RowIndex].Cells["Table_ID"].FormattedValue.ToString();
            this.lblTotalharga.Text = BilldataGridView.Rows[e.RowIndex].Cells["Bill_Totalprice"].FormattedValue.ToString();

        }
    }
}
