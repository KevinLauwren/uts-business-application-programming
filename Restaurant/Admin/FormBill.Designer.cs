namespace Admin
{
    partial class FormBill
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
            this.BilldataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBillid = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderid = new System.Windows.Forms.Label();
            this.lblNomormeja = new System.Windows.Forms.Label();
            this.lblTotalharga = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BilldataGridView
            // 
            this.BilldataGridView.AllowUserToAddRows = false;
            this.BilldataGridView.AllowUserToDeleteRows = false;
            this.BilldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilldataGridView.Location = new System.Drawing.Point(12, 204);
            this.BilldataGridView.Name = "BilldataGridView";
            this.BilldataGridView.ReadOnly = true;
            this.BilldataGridView.RowHeadersWidth = 62;
            this.BilldataGridView.RowTemplate.Height = 28;
            this.BilldataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BilldataGridView.Size = new System.Drawing.Size(860, 251);
            this.BilldataGridView.TabIndex = 0;
            this.BilldataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BilldataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nomor Meja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Harga";
            // 
            // lblBillid
            // 
            this.lblBillid.AutoSize = true;
            this.lblBillid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillid.Location = new System.Drawing.Point(155, 21);
            this.lblBillid.Name = "lblBillid";
            this.lblBillid.Size = new System.Drawing.Size(57, 20);
            this.lblBillid.TabIndex = 1;
            this.lblBillid.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(155, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // lblOrderid
            // 
            this.lblOrderid.AutoSize = true;
            this.lblOrderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderid.Location = new System.Drawing.Point(155, 86);
            this.lblOrderid.Name = "lblOrderid";
            this.lblOrderid.Size = new System.Drawing.Size(57, 20);
            this.lblOrderid.TabIndex = 1;
            this.lblOrderid.Text = "label1";
            // 
            // lblNomormeja
            // 
            this.lblNomormeja.AutoSize = true;
            this.lblNomormeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomormeja.Location = new System.Drawing.Point(155, 120);
            this.lblNomormeja.Name = "lblNomormeja";
            this.lblNomormeja.Size = new System.Drawing.Size(57, 20);
            this.lblNomormeja.TabIndex = 1;
            this.lblNomormeja.Text = "label1";
            // 
            // lblTotalharga
            // 
            this.lblTotalharga.AutoSize = true;
            this.lblTotalharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalharga.Location = new System.Drawing.Point(155, 157);
            this.lblTotalharga.Name = "lblTotalharga";
            this.lblTotalharga.Size = new System.Drawing.Size(57, 20);
            this.lblTotalharga.TabIndex = 1;
            this.lblTotalharga.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pilih Bill dibawah untuk ditampilkan";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 477);
            this.Controls.Add(this.lblTotalharga);
            this.Controls.Add(this.lblNomormeja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrderid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBillid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BilldataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilldataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBillid;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderid;
        private System.Windows.Forms.Label lblNomormeja;
        private System.Windows.Forms.Label lblTotalharga;
        private System.Windows.Forms.Label label6;
    }
}