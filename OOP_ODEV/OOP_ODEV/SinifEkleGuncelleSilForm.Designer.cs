namespace OOP_ODEV
{
    partial class SinifEkleGuncelleSilForm
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
            this.lstSubeSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSinifEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSinifEgitmen = new System.Windows.Forms.ComboBox();
            this.dtSinifBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSinifBilgileri = new System.Windows.Forms.GroupBox();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSinifEgitim = new System.Windows.Forms.ComboBox();
            this.dtSinifBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSinifKodu = new System.Windows.Forms.TextBox();
            this.btnSinifGuncelle = new System.Windows.Forms.Button();
            this.btnSinifSil = new System.Windows.Forms.Button();
            this.grpEgitimBilgileri = new System.Windows.Forms.GroupBox();
            this.txtSinifBitisSaati = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSinifBaslangicSaati = new System.Windows.Forms.MaskedTextBox();
            this.nmrEgitimSuresi = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLbxEgitimGunleri = new System.Windows.Forms.CheckedListBox();
            this.grpSinifBilgileri.SuspendLayout();
            this.grpEgitimBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEgitimSuresi)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSubeSiniflar
            // 
            this.lstSubeSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstSubeSiniflar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstSubeSiniflar.FullRowSelect = true;
            this.lstSubeSiniflar.GridLines = true;
            this.lstSubeSiniflar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSubeSiniflar.HideSelection = false;
            this.lstSubeSiniflar.Location = new System.Drawing.Point(12, 331);
            this.lstSubeSiniflar.Name = "lstSubeSiniflar";
            this.lstSubeSiniflar.Size = new System.Drawing.Size(641, 235);
            this.lstSubeSiniflar.TabIndex = 24;
            this.lstSubeSiniflar.UseCompatibleStateImageBehavior = false;
            this.lstSubeSiniflar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf Kodu";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Eğitim";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Başlangıç Tarihi";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bitiş Tarihi";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Eğitmen";
            this.columnHeader5.Width = 97;
            // 
            // btnSinifEkle
            // 
            this.btnSinifEkle.Location = new System.Drawing.Point(13, 269);
            this.btnSinifEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinifEkle.Name = "btnSinifEkle";
            this.btnSinifEkle.Size = new System.Drawing.Size(208, 45);
            this.btnSinifEkle.TabIndex = 20;
            this.btnSinifEkle.Text = "SINIF EKLE";
            this.btnSinifEkle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Eğitmen:";
            // 
            // cmbSinifEgitmen
            // 
            this.cmbSinifEgitmen.FormattingEnabled = true;
            this.cmbSinifEgitmen.Location = new System.Drawing.Point(143, 89);
            this.cmbSinifEgitmen.Name = "cmbSinifEgitmen";
            this.cmbSinifEgitmen.Size = new System.Drawing.Size(160, 26);
            this.cmbSinifEgitmen.TabIndex = 26;
            // 
            // dtSinifBaslangicTarihi
            // 
            this.dtSinifBaslangicTarihi.Location = new System.Drawing.Point(143, 58);
            this.dtSinifBaslangicTarihi.Name = "dtSinifBaslangicTarihi";
            this.dtSinifBaslangicTarihi.Size = new System.Drawing.Size(160, 25);
            this.dtSinifBaslangicTarihi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Eğitim:";
            // 
            // grpSinifBilgileri
            // 
            this.grpSinifBilgileri.Controls.Add(this.lblSubeAdi);
            this.grpSinifBilgileri.Controls.Add(this.label5);
            this.grpSinifBilgileri.Controls.Add(this.cmbSinifEgitim);
            this.grpSinifBilgileri.Controls.Add(this.dtSinifBitisTarihi);
            this.grpSinifBilgileri.Controls.Add(this.label4);
            this.grpSinifBilgileri.Controls.Add(this.label7);
            this.grpSinifBilgileri.Controls.Add(this.cmbSinifEgitmen);
            this.grpSinifBilgileri.Controls.Add(this.dtSinifBaslangicTarihi);
            this.grpSinifBilgileri.Controls.Add(this.label3);
            this.grpSinifBilgileri.Controls.Add(this.label2);
            this.grpSinifBilgileri.Controls.Add(this.label1);
            this.grpSinifBilgileri.Controls.Add(this.txtSinifKodu);
            this.grpSinifBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpSinifBilgileri.Name = "grpSinifBilgileri";
            this.grpSinifBilgileri.Size = new System.Drawing.Size(326, 221);
            this.grpSinifBilgileri.TabIndex = 21;
            this.grpSinifBilgileri.TabStop = false;
            this.grpSinifBilgileri.Text = "Sınıf Bilgileri";
            // 
            // lblSubeAdi
            // 
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(140, 187);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(38, 18);
            this.lblSubeAdi.TabIndex = 39;
            this.lblSubeAdi.Text = "?????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Şube:";
            // 
            // cmbSinifEgitim
            // 
            this.cmbSinifEgitim.FormattingEnabled = true;
            this.cmbSinifEgitim.Location = new System.Drawing.Point(143, 121);
            this.cmbSinifEgitim.Name = "cmbSinifEgitim";
            this.cmbSinifEgitim.Size = new System.Drawing.Size(160, 26);
            this.cmbSinifEgitim.TabIndex = 37;
            // 
            // dtSinifBitisTarihi
            // 
            this.dtSinifBitisTarihi.Location = new System.Drawing.Point(143, 153);
            this.dtSinifBitisTarihi.Name = "dtSinifBitisTarihi";
            this.dtSinifBitisTarihi.Size = new System.Drawing.Size(160, 25);
            this.dtSinifBitisTarihi.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sınıf Kodu:";
            // 
            // txtSinifKodu
            // 
            this.txtSinifKodu.Location = new System.Drawing.Point(143, 27);
            this.txtSinifKodu.Name = "txtSinifKodu";
            this.txtSinifKodu.Size = new System.Drawing.Size(160, 25);
            this.txtSinifKodu.TabIndex = 18;
            // 
            // btnSinifGuncelle
            // 
            this.btnSinifGuncelle.Location = new System.Drawing.Point(229, 269);
            this.btnSinifGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinifGuncelle.Name = "btnSinifGuncelle";
            this.btnSinifGuncelle.Size = new System.Drawing.Size(208, 45);
            this.btnSinifGuncelle.TabIndex = 26;
            this.btnSinifGuncelle.Text = "SINIF GÜNCELLE";
            this.btnSinifGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSinifSil
            // 
            this.btnSinifSil.Location = new System.Drawing.Point(445, 269);
            this.btnSinifSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinifSil.Name = "btnSinifSil";
            this.btnSinifSil.Size = new System.Drawing.Size(208, 45);
            this.btnSinifSil.TabIndex = 27;
            this.btnSinifSil.Text = "SINIF SİL";
            this.btnSinifSil.UseVisualStyleBackColor = true;
            // 
            // grpEgitimBilgileri
            // 
            this.grpEgitimBilgileri.Controls.Add(this.txtSinifBitisSaati);
            this.grpEgitimBilgileri.Controls.Add(this.label9);
            this.grpEgitimBilgileri.Controls.Add(this.txtSinifBaslangicSaati);
            this.grpEgitimBilgileri.Controls.Add(this.nmrEgitimSuresi);
            this.grpEgitimBilgileri.Controls.Add(this.label8);
            this.grpEgitimBilgileri.Controls.Add(this.label6);
            this.grpEgitimBilgileri.Controls.Add(this.chkLbxEgitimGunleri);
            this.grpEgitimBilgileri.Location = new System.Drawing.Point(344, 12);
            this.grpEgitimBilgileri.Name = "grpEgitimBilgileri";
            this.grpEgitimBilgileri.Size = new System.Drawing.Size(309, 221);
            this.grpEgitimBilgileri.TabIndex = 28;
            this.grpEgitimBilgileri.TabStop = false;
            this.grpEgitimBilgileri.Text = "Eğitim Bilgileri";
            // 
            // txtSinifBitisSaati
            // 
            this.txtSinifBitisSaati.Location = new System.Drawing.Point(232, 139);
            this.txtSinifBitisSaati.Mask = "00:00";
            this.txtSinifBitisSaati.Name = "txtSinifBitisSaati";
            this.txtSinifBitisSaati.Size = new System.Drawing.Size(60, 25);
            this.txtSinifBitisSaati.TabIndex = 45;
            this.txtSinifBitisSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSinifBitisSaati.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(145, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "Başlangıç - Bitiş Saati:";
            // 
            // txtSinifBaslangicSaati
            // 
            this.txtSinifBaslangicSaati.Location = new System.Drawing.Point(154, 139);
            this.txtSinifBaslangicSaati.Mask = "00:00";
            this.txtSinifBaslangicSaati.Name = "txtSinifBaslangicSaati";
            this.txtSinifBaslangicSaati.Size = new System.Drawing.Size(60, 25);
            this.txtSinifBaslangicSaati.TabIndex = 43;
            this.txtSinifBaslangicSaati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSinifBaslangicSaati.ValidatingType = typeof(System.DateTime);
            // 
            // nmrEgitimSuresi
            // 
            this.nmrEgitimSuresi.Location = new System.Drawing.Point(148, 69);
            this.nmrEgitimSuresi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrEgitimSuresi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEgitimSuresi.Name = "nmrEgitimSuresi";
            this.nmrEgitimSuresi.Size = new System.Drawing.Size(102, 25);
            this.nmrEgitimSuresi.TabIndex = 42;
            this.nmrEgitimSuresi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(145, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 39);
            this.label8.TabIndex = 41;
            this.label8.Text = "Eğitim Süresi (Saat/Gün):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Eğitim Günleri:";
            // 
            // chkLbxEgitimGunleri
            // 
            this.chkLbxEgitimGunleri.FormattingEnabled = true;
            this.chkLbxEgitimGunleri.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.chkLbxEgitimGunleri.Location = new System.Drawing.Point(6, 48);
            this.chkLbxEgitimGunleri.Name = "chkLbxEgitimGunleri";
            this.chkLbxEgitimGunleri.Size = new System.Drawing.Size(111, 144);
            this.chkLbxEgitimGunleri.TabIndex = 0;
            // 
            // SinifEkleGuncelleSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 578);
            this.Controls.Add(this.grpEgitimBilgileri);
            this.Controls.Add(this.btnSinifSil);
            this.Controls.Add(this.btnSinifGuncelle);
            this.Controls.Add(this.lstSubeSiniflar);
            this.Controls.Add(this.btnSinifEkle);
            this.Controls.Add(this.grpSinifBilgileri);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinifEkleGuncelleSilForm";
            this.Text = "SinifEkleGuncelleSilForm";
            this.grpSinifBilgileri.ResumeLayout(false);
            this.grpSinifBilgileri.PerformLayout();
            this.grpEgitimBilgileri.ResumeLayout(false);
            this.grpEgitimBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEgitimSuresi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSubeSiniflar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSinifEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSinifEgitmen;
        private System.Windows.Forms.DateTimePicker dtSinifBaslangicTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSinifBilgileri;
        private System.Windows.Forms.ComboBox cmbSinifEgitim;
        private System.Windows.Forms.DateTimePicker dtSinifBitisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinifKodu;
        private System.Windows.Forms.Button btnSinifGuncelle;
        private System.Windows.Forms.Button btnSinifSil;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpEgitimBilgileri;
        private System.Windows.Forms.CheckedListBox chkLbxEgitimGunleri;
        private System.Windows.Forms.NumericUpDown nmrEgitimSuresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSinifBaslangicSaati;
        private System.Windows.Forms.MaskedTextBox txtSinifBitisSaati;
        private System.Windows.Forms.Label label9;
    }
}