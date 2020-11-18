namespace Admin
{
    partial class FormAdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnMenuMakanan = new System.Windows.Forms.Button();
            this.btnBillCustomer = new System.Windows.Forms.Button();
            this.btnLaporanSales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selamat datang kembali,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(293, 20);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(256, 33);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "test";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenuMakanan
            // 
            this.btnMenuMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMakanan.Location = new System.Drawing.Point(183, 79);
            this.btnMenuMakanan.Name = "btnMenuMakanan";
            this.btnMenuMakanan.Size = new System.Drawing.Size(318, 62);
            this.btnMenuMakanan.TabIndex = 1;
            this.btnMenuMakanan.Text = "Tambah / Ubah Menu";
            this.btnMenuMakanan.UseVisualStyleBackColor = true;
            this.btnMenuMakanan.Click += new System.EventHandler(this.btnMenuMakanan_Click);
            // 
            // btnBillCustomer
            // 
            this.btnBillCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillCustomer.Location = new System.Drawing.Point(183, 158);
            this.btnBillCustomer.Name = "btnBillCustomer";
            this.btnBillCustomer.Size = new System.Drawing.Size(318, 62);
            this.btnBillCustomer.TabIndex = 2;
            this.btnBillCustomer.Text = "Cetak Bill Customer";
            this.btnBillCustomer.UseVisualStyleBackColor = true;
            this.btnBillCustomer.Click += new System.EventHandler(this.btnBillCustomer_Click);
            // 
            // btnLaporanSales
            // 
            this.btnLaporanSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanSales.Location = new System.Drawing.Point(183, 238);
            this.btnLaporanSales.Name = "btnLaporanSales";
            this.btnLaporanSales.Size = new System.Drawing.Size(318, 62);
            this.btnLaporanSales.TabIndex = 3;
            this.btnLaporanSales.Text = "Lihat Laporan Penjualan";
            this.btnLaporanSales.UseVisualStyleBackColor = true;
            this.btnLaporanSales.Click += new System.EventHandler(this.btnLaporanSales_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(537, 331);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 391);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporanSales);
            this.Controls.Add(this.btnBillCustomer);
            this.Controls.Add(this.btnMenuMakanan);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminPage";
            this.Text = "FormMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnMenuMakanan;
        private System.Windows.Forms.Button btnBillCustomer;
        private System.Windows.Forms.Button btnLaporanSales;
        private System.Windows.Forms.Button btnLogout;
    }
}