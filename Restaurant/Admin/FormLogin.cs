using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int chance = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Mohon Username Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mohon Password Diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else
            {
                string UsernameInput = this.txtUsername.Text.Trim();
                string PasswordInput = this.txtPassword.Text.Trim();
                string Full_name_admin = "";
                bool sukses = false;
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = @"Select Admin_ID, Full_name, Username, Password From Admin Where Username = @Username";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Username", UsernameInput);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        if (PasswordInput.Equals(reader["Password"].ToString()))
                                        {
                                            Full_name_admin = reader["Full_name"].ToString();
                                            sukses = true;
                                        }
                                        else
                                        {
                                            // gagal
                                            chance++;
                                        }
                                    }
                                }
                                else
                                {
                                    // gagal
                                    chance++;
                                }
                            }
                        }
                    }
                    if (sukses)
                    {
                        var form = new FormAdminPage(Full_name_admin);
                        form.ShowDialog();
                        this.txtUsername.Clear();
                        this.txtPassword.Clear();
                        this.txtUsername.Focus();
                    }
                    else
                    {
                        // kalau gagal
                        MessageBox.Show("Username atau Password yang dimasukan salah", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtUsername.Clear();
                        this.txtPassword.Clear();
                        this.txtUsername.Focus();
                    }
                    if (chance == 3)
                    {
                        
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
