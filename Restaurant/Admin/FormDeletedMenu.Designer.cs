namespace Admin
{
    partial class FormDeletedMenu
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_DataGridView = new System.Windows.Forms.DataGridView();
            this.txtMenukategori = new System.Windows.Forms.RichTextBox();
            this.picboxMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenuname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMenuid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(12, 14);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(133, 44);
            this.btnKembali.TabIndex = 13;
            this.btnKembali.Text = "< Go Back  ";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(790, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(263, 73);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.Location = new System.Drawing.Point(790, 395);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(263, 73);
            this.btnRecover.TabIndex = 14;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Deleted Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menu_DataGridView
            // 
            this.Menu_DataGridView.AllowUserToAddRows = false;
            this.Menu_DataGridView.AllowUserToDeleteRows = false;
            this.Menu_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_DataGridView.Location = new System.Drawing.Point(12, 109);
            this.Menu_DataGridView.Name = "Menu_DataGridView";
            this.Menu_DataGridView.ReadOnly = true;
            this.Menu_DataGridView.RowHeadersWidth = 62;
            this.Menu_DataGridView.RowTemplate.Height = 28;
            this.Menu_DataGridView.Size = new System.Drawing.Size(1056, 233);
            this.Menu_DataGridView.TabIndex = 21;
            this.Menu_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_DataGridView_CellClick);
            // 
            // txtMenukategori
            // 
            this.txtMenukategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenukategori.Location = new System.Drawing.Point(176, 459);
            this.txtMenukategori.Name = "txtMenukategori";
            this.txtMenukategori.ReadOnly = true;
            this.txtMenukategori.Size = new System.Drawing.Size(291, 109);
            this.txtMenukategori.TabIndex = 29;
            this.txtMenukategori.Text = "";
            // 
            // picboxMenu
            // 
            this.picboxMenu.Location = new System.Drawing.Point(488, 393);
            this.picboxMenu.Name = "picboxMenu";
            this.picboxMenu.Size = new System.Drawing.Size(274, 177);
            this.picboxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenu.TabIndex = 35;
            this.picboxMenu.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Menu ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMenuprice
            // 
            this.txtMenuprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuprice.Location = new System.Drawing.Point(176, 426);
            this.txtMenuprice.Name = "txtMenuprice";
            this.txtMenuprice.ReadOnly = true;
            this.txtMenuprice.Size = new System.Drawing.Size(195, 30);
            this.txtMenuprice.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMenuname
            // 
            this.txtMenuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuname.Location = new System.Drawing.Point(176, 393);
            this.txtMenuname.Name = "txtMenuname";
            this.txtMenuname.ReadOnly = true;
            this.txtMenuname.Size = new System.Drawing.Size(291, 30);
            this.txtMenuname.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 454);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kategori";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMenuid
            // 
            this.txtMenuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuid.Location = new System.Drawing.Point(176, 360);
            this.txtMenuid.Name = "txtMenuid";
            this.txtMenuid.ReadOnly = true;
            this.txtMenuid.Size = new System.Drawing.Size(100, 30);
            this.txtMenuid.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 33);
            this.label6.TabIndex = 34;
            this.label6.Text = "Menu Image:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDeletedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.txtMenukategori);
            this.Controls.Add(this.picboxMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenuprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMenuname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMenuid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Menu_DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnKembali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDeletedMenu";
            this.Text = "FormDeletedMenu";
            this.Load += new System.EventHandler(this.FormDeletedMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Menu_DataGridView;
        private System.Windows.Forms.RichTextBox txtMenukategori;
        private System.Windows.Forms.PictureBox picboxMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenuprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMenuname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMenuid;
        private System.Windows.Forms.Label label6;
    }
}