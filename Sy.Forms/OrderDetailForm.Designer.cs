namespace Sy.Forms
{
    partial class OrderDetailForm
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
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.dgvDetay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(27, 12);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(215, 24);
            this.cmbMusteriler.TabIndex = 0;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.CmbMusteriler_SelectedIndexChanged);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(27, 42);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(215, 484);
            this.lstSiparisler.TabIndex = 1;
            this.lstSiparisler.SelectedIndexChanged += new System.EventHandler(this.LstSiparisler_SelectedIndexChanged);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(27, 533);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 2;
            // 
            // dgvDetay
            // 
            this.dgvDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetay.Location = new System.Drawing.Point(248, 42);
            this.dgvDetay.Name = "dgvDetay";
            this.dgvDetay.RowHeadersWidth = 51;
            this.dgvDetay.RowTemplate.Height = 24;
            this.dgvDetay.Size = new System.Drawing.Size(737, 421);
            this.dgvDetay.TabIndex = 3;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 616);
            this.Controls.Add(this.dgvDetay);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.cmbMusteriler);
            this.Name = "OrderDetailForm";
            this.Text = "OrderDetailForm";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DataGridView dgvDetay;
    }
}