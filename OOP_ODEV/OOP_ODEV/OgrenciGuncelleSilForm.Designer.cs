namespace OOP_ODEV
{
    partial class OgrenciGuncelleSilForm
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
            this.components = new System.ComponentModel.Container();
            this.lstOgrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListeOgrenciSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmKullaniciSil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciResimSec = new System.Windows.Forms.Button();
            this.grpAramaYap = new System.Windows.Forms.GroupBox();
            this.btnOgrenciAramaYap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSinifaGoreAra = new System.Windows.Forms.ComboBox();
            this.txtAdaGoreAra = new System.Windows.Forms.TextBox();
            this.txtOgrenciCepTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.pbxOgrenciResmi = new System.Windows.Forms.PictureBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.grpOgrenciSinifBilgileri = new System.Windows.Forms.GroupBox();
            this.lblOgrenciSubeAdi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOgrenciSinifi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.grpOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.txtOgrenciMailAdresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtOgrenciDTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsListeOgrenciSil.SuspendLayout();
            this.grpAramaYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOgrenciResmi)).BeginInit();
            this.grpOgrenciSinifBilgileri.SuspendLayout();
            this.grpOgrenciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstOgrenciler.ContextMenuStrip = this.cmsListeOgrenciSil;
            this.lstOgrenciler.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstOgrenciler.FullRowSelect = true;
            this.lstOgrenciler.GridLines = true;
            this.lstOgrenciler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstOgrenciler.HideSelection = false;
            this.lstOgrenciler.Location = new System.Drawing.Point(12, 307);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(748, 235);
            this.lstOgrenciler.TabIndex = 24;
            this.lstOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lstOgrenciler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cep Telefonu";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mail Adresi";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sınıfı";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Şubesi";
            this.columnHeader6.Width = 111;
            // 
            // cmsListeOgrenciSil
            // 
            this.cmsListeOgrenciSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKullaniciSil});
            this.cmsListeOgrenciSil.Name = "cmsListeSil";
            this.cmsListeOgrenciSil.Size = new System.Drawing.Size(141, 26);
            // 
            // tsmKullaniciSil
            // 
            this.tsmKullaniciSil.Name = "tsmKullaniciSil";
            this.tsmKullaniciSil.Size = new System.Drawing.Size(140, 22);
            this.tsmKullaniciSil.Text = "Öğrenciyi Sil";
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(488, 138);
            this.btnOgrenciGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(130, 79);
            this.btnOgrenciGuncelle.TabIndex = 20;
            this.btnOgrenciGuncelle.Text = "ÖĞRENCİ GÜNCELLE";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciResimSec
            // 
            this.btnOgrenciResimSec.Location = new System.Drawing.Point(305, 151);
            this.btnOgrenciResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciResimSec.Name = "btnOgrenciResimSec";
            this.btnOgrenciResimSec.Size = new System.Drawing.Size(99, 34);
            this.btnOgrenciResimSec.TabIndex = 29;
            this.btnOgrenciResimSec.Text = "Resim Seç";
            this.btnOgrenciResimSec.UseVisualStyleBackColor = true;
            // 
            // grpAramaYap
            // 
            this.grpAramaYap.Controls.Add(this.btnOgrenciAramaYap);
            this.grpAramaYap.Controls.Add(this.label9);
            this.grpAramaYap.Controls.Add(this.label8);
            this.grpAramaYap.Controls.Add(this.cmbSinifaGoreAra);
            this.grpAramaYap.Controls.Add(this.txtAdaGoreAra);
            this.grpAramaYap.Location = new System.Drawing.Point(12, 234);
            this.grpAramaYap.Name = "grpAramaYap";
            this.grpAramaYap.Size = new System.Drawing.Size(748, 57);
            this.grpAramaYap.TabIndex = 25;
            this.grpAramaYap.TabStop = false;
            this.grpAramaYap.Text = "Arama";
            // 
            // btnOgrenciAramaYap
            // 
            this.btnOgrenciAramaYap.Location = new System.Drawing.Point(592, 20);
            this.btnOgrenciAramaYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciAramaYap.Name = "btnOgrenciAramaYap";
            this.btnOgrenciAramaYap.Size = new System.Drawing.Size(149, 26);
            this.btnOgrenciAramaYap.TabIndex = 31;
            this.btnOgrenciAramaYap.Text = "Arama Yap";
            this.btnOgrenciAramaYap.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Sınıfa Göre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ada / Soyada Göre:";
            // 
            // cmbSinifaGoreAra
            // 
            this.cmbSinifaGoreAra.FormattingEnabled = true;
            this.cmbSinifaGoreAra.Location = new System.Drawing.Point(415, 21);
            this.cmbSinifaGoreAra.Name = "cmbSinifaGoreAra";
            this.cmbSinifaGoreAra.Size = new System.Drawing.Size(137, 26);
            this.cmbSinifaGoreAra.TabIndex = 31;
            // 
            // txtAdaGoreAra
            // 
            this.txtAdaGoreAra.Location = new System.Drawing.Point(149, 21);
            this.txtAdaGoreAra.Name = "txtAdaGoreAra";
            this.txtAdaGoreAra.Size = new System.Drawing.Size(134, 25);
            this.txtAdaGoreAra.TabIndex = 31;
            // 
            // txtOgrenciCepTelefonu
            // 
            this.txtOgrenciCepTelefonu.Location = new System.Drawing.Point(109, 120);
            this.txtOgrenciCepTelefonu.Mask = "(999) 000-0000";
            this.txtOgrenciCepTelefonu.Name = "txtOgrenciCepTelefonu";
            this.txtOgrenciCepTelefonu.Size = new System.Drawing.Size(160, 25);
            this.txtOgrenciCepTelefonu.TabIndex = 30;
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(630, 138);
            this.btnOgrenciSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(130, 79);
            this.btnOgrenciSil.TabIndex = 23;
            this.btnOgrenciSil.Text = "ÖĞRENCİ SİL";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            // 
            // pbxOgrenciResmi
            // 
            this.pbxOgrenciResmi.Location = new System.Drawing.Point(305, 21);
            this.pbxOgrenciResmi.Name = "pbxOgrenciResmi";
            this.pbxOgrenciResmi.Size = new System.Drawing.Size(99, 124);
            this.pbxOgrenciResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOgrenciResmi.TabIndex = 28;
            this.pbxOgrenciResmi.TabStop = false;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(109, 58);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(160, 25);
            this.txtOgrenciSoyadi.TabIndex = 20;
            // 
            // grpOgrenciSinifBilgileri
            // 
            this.grpOgrenciSinifBilgileri.Controls.Add(this.lblOgrenciSubeAdi);
            this.grpOgrenciSinifBilgileri.Controls.Add(this.label10);
            this.grpOgrenciSinifBilgileri.Controls.Add(this.cmbOgrenciSinifi);
            this.grpOgrenciSinifBilgileri.Controls.Add(this.label7);
            this.grpOgrenciSinifBilgileri.Location = new System.Drawing.Point(488, 12);
            this.grpOgrenciSinifBilgileri.Name = "grpOgrenciSinifBilgileri";
            this.grpOgrenciSinifBilgileri.Size = new System.Drawing.Size(272, 109);
            this.grpOgrenciSinifBilgileri.TabIndex = 22;
            this.grpOgrenciSinifBilgileri.TabStop = false;
            this.grpOgrenciSinifBilgileri.Text = "Sınıf Bilgileri";
            // 
            // lblOgrenciSubeAdi
            // 
            this.lblOgrenciSubeAdi.AutoSize = true;
            this.lblOgrenciSubeAdi.Location = new System.Drawing.Point(87, 61);
            this.lblOgrenciSubeAdi.Name = "lblOgrenciSubeAdi";
            this.lblOgrenciSubeAdi.Size = new System.Drawing.Size(66, 18);
            this.lblOgrenciSubeAdi.TabIndex = 42;
            this.lblOgrenciSubeAdi.Text = "Şube Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Şubesi:";
            // 
            // cmbOgrenciSinifi
            // 
            this.cmbOgrenciSinifi.FormattingEnabled = true;
            this.cmbOgrenciSinifi.Location = new System.Drawing.Point(90, 21);
            this.cmbOgrenciSinifi.Name = "cmbOgrenciSinifi";
            this.cmbOgrenciSinifi.Size = new System.Drawing.Size(160, 26);
            this.cmbOgrenciSinifi.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sınıfı:";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(109, 27);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(160, 25);
            this.txtOgrenciAdi.TabIndex = 18;
            // 
            // grpOgrenciBilgileri
            // 
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciMailAdresi);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciCepTelefonu);
            this.grpOgrenciBilgileri.Controls.Add(this.btnOgrenciResimSec);
            this.grpOgrenciBilgileri.Controls.Add(this.pbxOgrenciResmi);
            this.grpOgrenciBilgileri.Controls.Add(this.label4);
            this.grpOgrenciBilgileri.Controls.Add(this.label6);
            this.grpOgrenciBilgileri.Controls.Add(this.dtOgrenciDTarihi);
            this.grpOgrenciBilgileri.Controls.Add(this.label3);
            this.grpOgrenciBilgileri.Controls.Add(this.label2);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciSoyadi);
            this.grpOgrenciBilgileri.Controls.Add(this.label1);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciAdi);
            this.grpOgrenciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            this.grpOgrenciBilgileri.Size = new System.Drawing.Size(417, 205);
            this.grpOgrenciBilgileri.TabIndex = 21;
            this.grpOgrenciBilgileri.TabStop = false;
            this.grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // txtOgrenciMailAdresi
            // 
            this.txtOgrenciMailAdresi.Location = new System.Drawing.Point(109, 160);
            this.txtOgrenciMailAdresi.Name = "txtOgrenciMailAdresi";
            this.txtOgrenciMailAdresi.Size = new System.Drawing.Size(160, 25);
            this.txtOgrenciMailAdresi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cep Telefonu:";
            // 
            // dtOgrenciDTarihi
            // 
            this.dtOgrenciDTarihi.Location = new System.Drawing.Point(109, 89);
            this.dtOgrenciDTarihi.Name = "dtOgrenciDTarihi";
            this.dtOgrenciDTarihi.Size = new System.Drawing.Size(160, 25);
            this.dtOgrenciDTarihi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı:";
            // 
            // OgrenciGuncelleSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 550);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.grpAramaYap);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.grpOgrenciSinifBilgileri);
            this.Controls.Add(this.grpOgrenciBilgileri);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgrenciGuncelleSilForm";
            this.Text = "OgrenciGuncelleSilForm";
            this.cmsListeOgrenciSil.ResumeLayout(false);
            this.grpAramaYap.ResumeLayout(false);
            this.grpAramaYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOgrenciResmi)).EndInit();
            this.grpOgrenciSinifBilgileri.ResumeLayout(false);
            this.grpOgrenciSinifBilgileri.PerformLayout();
            this.grpOgrenciBilgileri.ResumeLayout(false);
            this.grpOgrenciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOgrenciler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmsListeOgrenciSil;
        private System.Windows.Forms.ToolStripMenuItem tsmKullaniciSil;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciResimSec;
        private System.Windows.Forms.GroupBox grpAramaYap;
        private System.Windows.Forms.Button btnOgrenciAramaYap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSinifaGoreAra;
        private System.Windows.Forms.TextBox txtAdaGoreAra;
        private System.Windows.Forms.MaskedTextBox txtOgrenciCepTelefonu;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.PictureBox pbxOgrenciResmi;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.GroupBox grpOgrenciSinifBilgileri;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOgrenciSinifi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtOgrenciDTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgrenciSubeAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgrenciMailAdresi;
        private System.Windows.Forms.Label label4;
    }
}