namespace OOP_ODEV
{
    partial class KullaniciEkleForm
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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciMailAdresi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.chkKullaniciOtoParola = new System.Windows.Forms.CheckBox();
            this.grpKullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbKullaniciSubesi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullaniciCepTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.btnKullaniciResimSec = new System.Windows.Forms.Button();
            this.pbxKullaniciResmi = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKullaniciGorevi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtKullaniciDTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.grpUyelikBilgileri = new System.Windows.Forms.GroupBox();
            this.grpKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKullaniciResmi)).BeginInit();
            this.grpUyelikBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(401, 159);
            this.btnKullaniciEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(272, 73);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "KULLANICI EKLE";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Adresi:";
            // 
            // txtKullaniciMailAdresi
            // 
            this.txtKullaniciMailAdresi.Location = new System.Drawing.Point(116, 24);
            this.txtKullaniciMailAdresi.Name = "txtKullaniciMailAdresi";
            this.txtKullaniciMailAdresi.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciMailAdresi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parola:";
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Location = new System.Drawing.Point(116, 55);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciParola.TabIndex = 9;
            // 
            // chkKullaniciOtoParola
            // 
            this.chkKullaniciOtoParola.AutoSize = true;
            this.chkKullaniciOtoParola.Location = new System.Drawing.Point(57, 86);
            this.chkKullaniciOtoParola.Name = "chkKullaniciOtoParola";
            this.chkKullaniciOtoParola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkKullaniciOtoParola.Size = new System.Drawing.Size(195, 22);
            this.chkKullaniciOtoParola.TabIndex = 11;
            this.chkKullaniciOtoParola.Text = "Parolayı otomatik oluştur";
            this.chkKullaniciOtoParola.UseVisualStyleBackColor = true;
            this.chkKullaniciOtoParola.CheckedChanged += new System.EventHandler(this.chkKullaniciOtoParola_CheckedChanged);
            // 
            // grpKullaniciBilgileri
            // 
            this.grpKullaniciBilgileri.Controls.Add(this.cmbKullaniciSubesi);
            this.grpKullaniciBilgileri.Controls.Add(this.label8);
            this.grpKullaniciBilgileri.Controls.Add(this.txtKullaniciCepTelefonu);
            this.grpKullaniciBilgileri.Controls.Add(this.btnKullaniciResimSec);
            this.grpKullaniciBilgileri.Controls.Add(this.pbxKullaniciResmi);
            this.grpKullaniciBilgileri.Controls.Add(this.label7);
            this.grpKullaniciBilgileri.Controls.Add(this.cmbKullaniciGorevi);
            this.grpKullaniciBilgileri.Controls.Add(this.label6);
            this.grpKullaniciBilgileri.Controls.Add(this.dtKullaniciDTarihi);
            this.grpKullaniciBilgileri.Controls.Add(this.label3);
            this.grpKullaniciBilgileri.Controls.Add(this.label2);
            this.grpKullaniciBilgileri.Controls.Add(this.txtKullaniciSoyadi);
            this.grpKullaniciBilgileri.Controls.Add(this.label1);
            this.grpKullaniciBilgileri.Controls.Add(this.txtKullaniciAdi);
            this.grpKullaniciBilgileri.Location = new System.Drawing.Point(13, 13);
            this.grpKullaniciBilgileri.Name = "grpKullaniciBilgileri";
            this.grpKullaniciBilgileri.Size = new System.Drawing.Size(381, 219);
            this.grpKullaniciBilgileri.TabIndex = 12;
            this.grpKullaniciBilgileri.TabStop = false;
            this.grpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // cmbKullaniciSubesi
            // 
            this.cmbKullaniciSubesi.FormattingEnabled = true;
            this.cmbKullaniciSubesi.Location = new System.Drawing.Point(109, 183);
            this.cmbKullaniciSubesi.Name = "cmbKullaniciSubesi";
            this.cmbKullaniciSubesi.Size = new System.Drawing.Size(134, 26);
            this.cmbKullaniciSubesi.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Şubesi:";
            // 
            // txtKullaniciCepTelefonu
            // 
            this.txtKullaniciCepTelefonu.Location = new System.Drawing.Point(109, 120);
            this.txtKullaniciCepTelefonu.Mask = "(999) 000-0000";
            this.txtKullaniciCepTelefonu.Name = "txtKullaniciCepTelefonu";
            this.txtKullaniciCepTelefonu.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciCepTelefonu.TabIndex = 30;
            // 
            // btnKullaniciResimSec
            // 
            this.btnKullaniciResimSec.Location = new System.Drawing.Point(267, 151);
            this.btnKullaniciResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciResimSec.Name = "btnKullaniciResimSec";
            this.btnKullaniciResimSec.Size = new System.Drawing.Size(99, 58);
            this.btnKullaniciResimSec.TabIndex = 29;
            this.btnKullaniciResimSec.Text = "Resim Seç";
            this.btnKullaniciResimSec.UseVisualStyleBackColor = true;
            this.btnKullaniciResimSec.Click += new System.EventHandler(this.btnKullaniciResimSec_Click);
            // 
            // pbxKullaniciResmi
            // 
            this.pbxKullaniciResmi.Location = new System.Drawing.Point(267, 21);
            this.pbxKullaniciResmi.Name = "pbxKullaniciResmi";
            this.pbxKullaniciResmi.Size = new System.Drawing.Size(99, 124);
            this.pbxKullaniciResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKullaniciResmi.TabIndex = 28;
            this.pbxKullaniciResmi.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Görevi:";
            // 
            // cmbKullaniciGorevi
            // 
            this.cmbKullaniciGorevi.FormattingEnabled = true;
            this.cmbKullaniciGorevi.Location = new System.Drawing.Point(109, 151);
            this.cmbKullaniciGorevi.Name = "cmbKullaniciGorevi";
            this.cmbKullaniciGorevi.Size = new System.Drawing.Size(134, 26);
            this.cmbKullaniciGorevi.TabIndex = 26;
            this.cmbKullaniciGorevi.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciGorevi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cep Telefonu:";
            // 
            // dtKullaniciDTarihi
            // 
            this.dtKullaniciDTarihi.Location = new System.Drawing.Point(109, 89);
            this.dtKullaniciDTarihi.Name = "dtKullaniciDTarihi";
            this.dtKullaniciDTarihi.Size = new System.Drawing.Size(134, 25);
            this.dtKullaniciDTarihi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
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
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(109, 58);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciSoyadi.TabIndex = 20;
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
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(109, 27);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(134, 25);
            this.txtKullaniciAdi.TabIndex = 18;
            // 
            // grpUyelikBilgileri
            // 
            this.grpUyelikBilgileri.Controls.Add(this.txtKullaniciMailAdresi);
            this.grpUyelikBilgileri.Controls.Add(this.label4);
            this.grpUyelikBilgileri.Controls.Add(this.chkKullaniciOtoParola);
            this.grpUyelikBilgileri.Controls.Add(this.label5);
            this.grpUyelikBilgileri.Controls.Add(this.txtKullaniciParola);
            this.grpUyelikBilgileri.Location = new System.Drawing.Point(401, 13);
            this.grpUyelikBilgileri.Name = "grpUyelikBilgileri";
            this.grpUyelikBilgileri.Size = new System.Drawing.Size(272, 139);
            this.grpUyelikBilgileri.TabIndex = 13;
            this.grpUyelikBilgileri.TabStop = false;
            this.grpUyelikBilgileri.Text = "Üyelik Bilgileri";
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 242);
            this.Controls.Add(this.grpUyelikBilgileri);
            this.Controls.Add(this.grpKullaniciBilgileri);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KullaniciEkleForm";
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            this.grpKullaniciBilgileri.ResumeLayout(false);
            this.grpKullaniciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKullaniciResmi)).EndInit();
            this.grpUyelikBilgileri.ResumeLayout(false);
            this.grpUyelikBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciMailAdresi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.CheckBox chkKullaniciOtoParola;
        private System.Windows.Forms.GroupBox grpKullaniciBilgileri;
        private System.Windows.Forms.MaskedTextBox txtKullaniciCepTelefonu;
        private System.Windows.Forms.Button btnKullaniciResimSec;
        private System.Windows.Forms.PictureBox pbxKullaniciResmi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKullaniciGorevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtKullaniciDTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.GroupBox grpUyelikBilgileri;
        private System.Windows.Forms.ComboBox cmbKullaniciSubesi;
        private System.Windows.Forms.Label label8;
    }
}