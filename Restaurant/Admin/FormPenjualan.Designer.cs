namespace Admin
{
    partial class FormPenjualan
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
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BilldataGridView
            // 
            this.BilldataGridView.AllowUserToAddRows = false;
            this.BilldataGridView.AllowUserToDeleteRows = false;
            this.BilldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilldataGridView.Location = new System.Drawing.Point(12, 48);
            this.BilldataGridView.Name = "BilldataGridView";
            this.BilldataGridView.ReadOnly = true;
            this.BilldataGridView.RowHeadersWidth = 62;
            this.BilldataGridView.RowTemplate.Height = 28;
            this.BilldataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BilldataGridView.Size = new System.Drawing.Size(860, 477);
            this.BilldataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laporan penjualan:";
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BilldataGridView);
            this.Name = "FormPenjualan";
            this.Text = "FormPenjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilldataGridView;
        private System.Windows.Forms.Label label1;
    }
}