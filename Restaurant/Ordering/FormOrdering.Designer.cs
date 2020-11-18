namespace Ordering
{
    partial class FormOrdering
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
            this.label2 = new System.Windows.Forms.Label();
            this.Menu_DataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.picboxMenu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBestseller = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.labelNomormeja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantityfood = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Order_DataGridView = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNomororder = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBilling = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantityfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang ke Restoran Rasa Kita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table No.";
            // 
            // Menu_DataGridView
            // 
            this.Menu_DataGridView.AllowUserToAddRows = false;
            this.Menu_DataGridView.AllowUserToDeleteRows = false;
            this.Menu_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_DataGridView.Location = new System.Drawing.Point(14, 73);
            this.Menu_DataGridView.Name = "Menu_DataGridView";
            this.Menu_DataGridView.ReadOnly = true;
            this.Menu_DataGridView.RowHeadersWidth = 62;
            this.Menu_DataGridView.RowTemplate.Height = 28;
            this.Menu_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Menu_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Menu_DataGridView.Size = new System.Drawing.Size(694, 238);
            this.Menu_DataGridView.TabIndex = 2;
            this.Menu_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_DataGridView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Daftar Menu:";
            // 
            // picboxMenu
            // 
            this.picboxMenu.Location = new System.Drawing.Point(723, 101);
            this.picboxMenu.Name = "picboxMenu";
            this.picboxMenu.Size = new System.Drawing.Size(295, 210);
            this.picboxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMenu.TabIndex = 3;
            this.picboxMenu.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gambar:";
            // 
            // btnBestseller
            // 
            this.btnBestseller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestseller.Location = new System.Drawing.Point(14, 318);
            this.btnBestseller.Name = "btnBestseller";
            this.btnBestseller.Size = new System.Drawing.Size(135, 33);
            this.btnBestseller.TabIndex = 4;
            this.btnBestseller.Text = "Best Seller";
            this.btnBestseller.UseVisualStyleBackColor = true;
            this.btnBestseller.Click += new System.EventHandler(this.btnBestseller_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(155, 318);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(108, 33);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.Location = new System.Drawing.Point(269, 317);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(104, 33);
            this.btnDrinks.TabIndex = 4;
            this.btnDrinks.Text = "Minuman";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(379, 318);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(111, 33);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // labelNomormeja
            // 
            this.labelNomormeja.AutoSize = true;
            this.labelNomormeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomormeja.Location = new System.Drawing.Point(112, 9);
            this.labelNomormeja.Name = "labelNomormeja";
            this.labelNomormeja.Size = new System.Drawing.Size(51, 25);
            this.labelNomormeja.TabIndex = 0;
            this.labelNomormeja.Text = "Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // Quantityfood
            // 
            this.Quantityfood.Location = new System.Drawing.Point(624, 320);
            this.Quantityfood.Name = "Quantityfood";
            this.Quantityfood.Size = new System.Drawing.Size(69, 26);
            this.Quantityfood.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1007, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "------------------------------------------------- Orderan -----------------------" +
    "-----------------------------------------";
            // 
            // Order_DataGridView
            // 
            this.Order_DataGridView.AllowUserToAddRows = false;
            this.Order_DataGridView.AllowUserToDeleteRows = false;
            this.Order_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_DataGridView.Location = new System.Drawing.Point(17, 403);
            this.Order_DataGridView.Name = "Order_DataGridView";
            this.Order_DataGridView.ReadOnly = true;
            this.Order_DataGridView.RowHeadersWidth = 62;
            this.Order_DataGridView.RowTemplate.Height = 28;
            this.Order_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Order_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_DataGridView.Size = new System.Drawing.Size(694, 238);
            this.Order_DataGridView.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(723, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(295, 42);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(728, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(723, 483);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(295, 90);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(723, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. Order: ";
            // 
            // labelNomororder
            // 
            this.labelNomororder.AutoSize = true;
            this.labelNomororder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomororder.Location = new System.Drawing.Point(975, 403);
            this.labelNomororder.Name = "labelNomororder";
            this.labelNomororder.Size = new System.Drawing.Size(43, 25);
            this.labelNomororder.TabIndex = 0;
            this.labelNomororder.Text = "test";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(723, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Billing:";
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.Location = new System.Drawing.Point(877, 438);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(24, 25);
            this.lblBilling.TabIndex = 0;
            this.lblBilling.Text = "0";
            // 
            // FormOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 679);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.Quantityfood);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnBestseller);
            this.Controls.Add(this.picboxMenu);
            this.Controls.Add(this.Order_DataGridView);
            this.Controls.Add(this.Menu_DataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNomormeja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBilling);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelNomororder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOrdering";
            this.Text = "Form Ordering";
            this.Load += new System.EventHandler(this.FormOrdering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantityfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Menu_DataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboxMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBestseller;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label labelNomormeja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Quantityfood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Order_DataGridView;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNomororder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBilling;
    }
}

