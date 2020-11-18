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
    public partial class FormEditMenu : Form
    {
        public FormEditMenu()
        {
            InitializeComponent();
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
            else if (comboBoxKategori.Text == "")
            {
                MessageBox.Show("Mohon Deskripsi Menu Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxKategori.Focus();
                return false;
            }
            else if (picboxMenu == null)
            {
                MessageBox.Show("Mohon mengUpload Foto Makanan terlebih dahulu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            this.txtMenuid.Clear();
            this.txtMenuname.Clear();
            this.comboBoxKategori.Text = "";
            this.txtMenuprice.Clear();
            this.picboxMenu.Image = null;
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
        }

//========================================================================================

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");

        private void FormEditMenu_Load(object sender, EventArgs e)
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
                this.comboBoxKategori.Text = Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_kategori"].FormattedValue.ToString();
                byte[] image = (byte[])Menu_DataGridView.Rows[e.RowIndex].Cells["Menu_image"].Value;
                MemoryStream ms = new MemoryStream(image);
                picboxMenu.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        string PictureMenu = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*jpg|png files(*.png)|*png|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                PictureMenu = dialog.FileName.ToString();
                picboxMenu.ImageLocation = PictureMenu;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Menu_Available VALUES (@Menu_ID, @Menu_name, @Menu_price, @Menu_kategori, @Menu_image)", conn);

                    MemoryStream stream = new MemoryStream();
                    picboxMenu.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] MenuImage = stream.ToArray();

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);
                    cmd.Parameters.AddWithValue("@Menu_name", txtMenuname.Text);
                    cmd.Parameters.AddWithValue("@Menu_price", txtMenuprice.Text);
                    cmd.Parameters.AddWithValue("@Menu_kategori", comboBoxKategori.Text);
                    cmd.Parameters.AddWithValue("@Menu_image", MenuImage);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Menu Makanan berhasil ditambahkan ke Database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMenuRecord();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Menu_Available SET Menu_name = @Menu_name, Menu_price = @Menu_price, Menu_kategori = @Menu_kategori WHERE Menu_ID = @Menu_ID", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);
                    cmd.Parameters.AddWithValue("@Menu_name", txtMenuname.Text);
                    cmd.Parameters.AddWithValue("@Menu_price", txtMenuprice.Text);
                    cmd.Parameters.AddWithValue("@Menu_kategori", comboBoxKategori.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Menu Makanan berhasil diupdate ke Database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMenuRecord();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu_Available WHERE Menu_ID = @Menu_ID", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    //Pindah menu yg dihapus ke database menu terhapus
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Menu_Deleted VALUES (@Menu_ID, @Menu_name, @Menu_price, @Menu_kategori, @Menu_image)", conn);

                    MemoryStream stream = new MemoryStream();
                    picboxMenu.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] MenuImage2 = stream.ToArray();

                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@Menu_ID", txtMenuid.Text);
                    cmd2.Parameters.AddWithValue("@Menu_name", txtMenuname.Text);
                    cmd2.Parameters.AddWithValue("@Menu_price", txtMenuprice.Text);
                    cmd2.Parameters.AddWithValue("@Menu_kategori", comboBoxKategori.Text);
                    cmd2.Parameters.AddWithValue("@Menu_image", MenuImage2);

                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Menu Makanan berhasil dihapus sementara (Masih tersimpan di dalam Database)", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetMenuRecord();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.txtMenuid.Focus();
        }

        private void btnDeletedmenu_Click(object sender, EventArgs e)
        {
            var form = new FormDeletedMenu();
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetMenuRecord();
        }
    }
}
