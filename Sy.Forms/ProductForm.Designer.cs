namespace Sy.Forms
{
    partial class ProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.nKritikStok = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKritikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kritik Stok:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(94, 9);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(196, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(94, 38);
            this.nFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(196, 22);
            this.nFiyat.TabIndex = 4;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nKritikStok
            // 
            this.nKritikStok.Location = new System.Drawing.Point(94, 67);
            this.nKritikStok.Name = "nKritikStok";
            this.nKritikStok.Size = new System.Drawing.Size(196, 22);
            this.nKritikStok.TabIndex = 5;
            this.nKritikStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(296, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 81);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(514, 9);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(289, 22);
            this.txtAra.TabIndex = 7;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(514, 38);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(289, 388);
            this.lstUrunler.TabIndex = 8;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBilgi.Location = new System.Drawing.Point(18, 123);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(434, 26);
            this.lblBilgi.TabIndex = 9;
            this.lblBilgi.Text = "lblBilgi   burada ürünlerin bilgisini vereceğiz";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nKritikStok);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKritikStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.NumericUpDown nKritikStok;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label lblBilgi;
    }
}