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
    public partial class FormPenjualan : Form
    {
        public FormPenjualan()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");



        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Bill", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            BilldataGridView.DataSource = dt;
        }
    }
}
