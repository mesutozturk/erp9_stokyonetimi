namespace Sy.Forms
{
    partial class OrderForm
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.grpSiparisDetay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.nEklenecekMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nAlisFiyati = new System.Windows.Forms.NumericUpDown();
            this.grpSiparisDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEklenecekMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(13, 45);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(304, 580);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(304, 22);
            this.txtAra.TabIndex = 1;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // grpSiparisDetay
            // 
            this.grpSiparisDetay.Controls.Add(this.btnKaydet);
            this.grpSiparisDetay.Controls.Add(this.nAlisFiyati);
            this.grpSiparisDetay.Controls.Add(this.label4);
            this.grpSiparisDetay.Controls.Add(this.nEklenecekMiktar);
            this.grpSiparisDetay.Controls.Add(this.label3);
            this.grpSiparisDetay.Controls.Add(this.label2);
            this.grpSiparisDetay.Controls.Add(this.lblStokMiktari);
            this.grpSiparisDetay.Controls.Add(this.lblUrunAdi);
            this.grpSiparisDetay.Controls.Add(this.label1);
            this.grpSiparisDetay.Location = new System.Drawing.Point(338, 13);
            this.grpSiparisDetay.Name = "grpSiparisDetay";
            this.grpSiparisDetay.Size = new System.Drawing.Size(293, 231);
            this.grpSiparisDetay.TabIndex = 2;
            this.grpSiparisDetay.TabStop = false;
            this.grpSiparisDetay.Text = "Sipariş Detay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mevcut Stok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenecek Miktar:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(146, 28);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(93, 22);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "lblUrunAdi";
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokMiktari.Location = new System.Drawing.Point(147, 60);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(120, 22);
            this.lblStokMiktari.TabIndex = 0;
            this.lblStokMiktari.Text = "lblStokMiktari";
            // 
            // nEklenecekMiktar
            // 
            this.nEklenecekMiktar.Location = new System.Drawing.Point(147, 93);
            this.nEklenecekMiktar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nEklenecekMiktar.Name = "nEklenecekMiktar";
            this.nEklenecekMiktar.Size = new System.Drawing.Size(120, 22);
            this.nEklenecekMiktar.TabIndex = 1;
            this.nEklenecekMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(147, 149);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 59);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // nAlisFiyati
            // 
            this.nAlisFiyati.DecimalPlaces = 2;
            this.nAlisFiyati.Location = new System.Drawing.Point(147, 121);
            this.nAlisFiyati.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nAlisFiyati.Name = "nAlisFiyati";
            this.nAlisFiyati.Size = new System.Drawing.Size(120, 22);
            this.nAlisFiyati.TabIndex = 1;
            this.nAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 649);
            this.Controls.Add(this.grpSiparisDetay);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrunler);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.grpSiparisDetay.ResumeLayout(false);
            this.grpSiparisDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEklenecekMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox grpSiparisDetay;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nEklenecekMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nAlisFiyati;
        private System.Windows.Forms.Label label4;
    }
}