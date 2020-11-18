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
    public partial class FormDeletedMenu : Form
    {
        public FormDeletedMenu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");

        private void ClearForm()
        {
            this.txtMenuid.Clear();
            this.txtMenuname.Clear();
            this.txtMenukategori.Clear();
            this.txtMenuprice.Clear();
            this.picboxMenu.Image = null;
        }

        private void GetMenuRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Menu_Deleted", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();

            Menu_DataGridView.DataSource = dt;
        }

        private bool isValid()
        {
            if (this.txtMenuid.Text.Trim() == "")
            {
                MessageBox.Show("Mohon ID Menu Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMenuid.Focus();
                return false;
            }
            else if (txtMenuname.Text.Trim() == "")
            {
                MessageBox.Show("Mohon Nama Menu Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMenuname.Focus();
                return false;
            }
            else if (txtMenuprice.Text.Trim() == "")
            {
                MessageBox.Show("Mohon Harga Menu Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMenuprice.Focus();
                return false;
            }
            else if (txtMenukategori.Text.Trim() == "")
            {
                MessageBox.Show("Mohon Deskripsi Menu Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMenukategori.Focus();
                return false;
            }
            else if (picboxMenu == null)
            {
                MessageBox.Show("Mohon mengUpload Foto Makanan terlebih dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMenukategori.Focus();
                return false;
            }
            return true;
        }

        //========================================================================================

        private void FormDeletedMenu_Load(object sender, EventArgs e)
        {
            GetMenuRecord();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtMenuid.Text = Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_ID"].FormattedValue.ToString();
                this.txtMenuname.Text = Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_name"].FormattedValue.ToString();
                this.txtMenuprice.Text = Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_price"].FormattedValue.ToString();
                this.txtMenukategori.Text = Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_kategori"].FormattedValue.ToString();
                byte[] image = (byte[])Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_image"].Value;
                MemoryStream ms = new MemoryStream(image);
                picboxMenu.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu_Deleted WHERE Menu_ID = @Menu_ID", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //Pindah menu yg dihapus ke database menu terhapus

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Menu_Available VALUES (@Menu_ID, @Menu_name, @Menu_price, @Menu_kategori, @Menu_image)", conn);

                    MemoryStream stream = new MemoryStream();
                    picboxMenu.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] MenuImage2 = stream.ToArray();

                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);
                    cmd2.Parameters.AddWithValue("@Menu_name", txtMenuname.Text);
                    cmd2.Parameters.AddWithValue("@Menu_price", txtMenuprice.Text);
                    cmd2.Parameters.AddWithValue("@Menu_kategori", txtMenukategori.Text);
                    cmd2.Parameters.AddWithValue("@Menu_image", MenuImage2);

                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Menu Makanan berhasil di recover", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMenuRecord();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try 
                { 
                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu_Deleted WHERE Menu_ID = @Menu_ID", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Menu Makanan telah dihapus secara permanen", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    GetMenuRecord();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
