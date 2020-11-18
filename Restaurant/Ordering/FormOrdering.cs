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

namespace Ordering
{
    public partial class FormOrdering : Form
    {
        private int total_billing;

        public FormOrdering(string Nomor_Meja)
        {
            InitializeComponent();
            this.labelNomormeja.Text = Nomor_Meja;
        }

        private void ShowFoodPicture(int num)
        {
            byte[] image = (byte[])Menu_DataGridView.Rows[num].Cells["Menu_image"].Value;
            MemoryStream ms = new MemoryStream(image);
            picboxMenu.Image = Image.FromStream(ms);
        }

        private void GetMenuRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Menu_Available", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            Menu_DataGridView.DataSource = dt;
            ShowFoodPicture(0);
        }

        private void GetOrderRecord(string query)
        {
            if (query == "all")
            {
                SqlCommand cmd = new SqlCommand("Select * from Order_Items", conn);
                DataTable dt_order = new DataTable();

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dt_order.Load(reader);
                conn.Close();

                Order_DataGridView.DataSource = dt_order;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt_order = new DataTable();

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dt_order.Load(reader);
                conn.Close();

                Order_DataGridView.DataSource = dt_order;
            }
            
        }

        private void GetMenuKategori(string kategori)
        {
            SqlCommand cmd = new SqlCommand("Select * from Menu_Available WHERE Menu_kategori = @Menu_kategori", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Menu_kategori", kategori);

            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            Menu_DataGridView.DataSource = dt;
            ShowFoodPicture(0);
        }

        //========================================================================================

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");

        private void FormOrdering_Load(object sender, EventArgs e)
        {
            GetMenuRecord();
            this.labelNomororder.Text = Generate_OrderID().ToString();
        }

        private void Menu_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ShowFoodPicture(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnBestseller_Click(object sender, EventArgs e)
        {
            GetMenuKategori("Best Seller");
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            GetMenuKategori("Makanan");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            GetMenuKategori("Minuman");
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            GetMenuRecord();
        }

        private int Generate_OrderID()
        {
            int order_ID = 0;
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"Select Order_ID from Order_Items Order By Order_ID DESC";

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!DBNull.Value.Equals(reader["Order_ID"]))
                                {
                                    order_ID = int.Parse(reader["Order_ID"].ToString()) + 1;
                                    return order_ID;
                                }
                            }
                            return 1;
                        }
                        return 1;
                    }
                }
            }
        }

        private int Generate_BillID()
        {
            int Bill_ID = 0;
            using (var conn = new Connection().CreateAndOpenConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"Select Bill_ID from Bill Order By Bill_ID DESC";

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!DBNull.Value.Equals(reader["Bill_ID"]))
                                {
                                    Bill_ID = int.Parse(reader["Bill_ID"].ToString()) + 1;
                                    return Bill_ID;
                                }
                            }
                            return 1;
                        }
                        return 1;
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Quantityfood.Value != 0)
            {
                int food_price = Convert.ToInt32(Menu_DataGridView.SelectedRows[0].Cells[2].FormattedValue.ToString());
                int total_price = food_price * Convert.ToInt32(Quantityfood.Value);

                if (MessageBox.Show("Apakah anda sudah yakin ingin memesan menu ini?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    

                    SqlCommand cmd = new SqlCommand("INSERT INTO Order_Items VALUES (@Order_ID, @Menu_Name, @Order_Qty, @Order_Total)", conn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Order_ID", this.labelNomororder.Text);
                    cmd.Parameters.AddWithValue("@Menu_Name", Menu_DataGridView.SelectedRows[0].Cells[1].FormattedValue.ToString());
                    cmd.Parameters.AddWithValue("@Order_Qty", Quantityfood.Value);
                    cmd.Parameters.AddWithValue("@Order_Total", total_price);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    total_billing += total_price;
                    this.lblBilling.Text = total_billing.ToString();

                    MessageBox.Show("Menu Makanan berhasil diorder", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetOrderRecord("Select * from Order_Items Where Order_ID = " + this.labelNomororder.Text);
                    Quantityfood.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Masukan Jumlah Orderan terlebih dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Bill VALUES (@Bill_ID, @Date, @Order_ID, @Table_ID, @Bill_Totalprice)", conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Bill_ID", Generate_BillID().ToString());
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Order_ID", this.labelNomororder.Text);
            cmd.Parameters.AddWithValue("@Table_ID", this.labelNomormeja.Text);
            cmd.Parameters.AddWithValue("@Bill_Totalprice", total_billing);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Silahkan pergi ke kasir untuk pembayaran", "Terima Kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var form = new FormThankyou();
            form.ShowDialog();
            this.Close();
        }
    }
}
