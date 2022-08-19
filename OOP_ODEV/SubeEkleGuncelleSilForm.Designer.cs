namespace OOP_ODEV
{
    partial class SubeEkleGuncelleSilForm
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
            this.btnSubeSil = new System.Windows.Forms.Button();
            this.btnSubeGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubeKoordinatoru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSubeBilgileri = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.grpSubeBilgileri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubeTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubeMaili = new System.Windows.Forms.TextBox();
            this.txtSubeAdresi = new System.Windows.Forms.TextBox();
            this.grpSubeBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubeSil
            // 
            this.btnSubeSil.Location = new System.Drawing.Point(445, 177);
            this.btnSubeSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubeSil.Name = "btnSubeSil";
            this.btnSubeSil.Size = new System.Drawing.Size(208, 45);
            this.btnSubeSil.TabIndex = 32;
            this.btnSubeSil.Text = "ŞUBE SİL";
            this.btnSubeSil.UseVisualStyleBackColor = true;
            this.btnSubeSil.Click += new System.EventHandler(this.btnSubeSil_Click);
            // 
            // btnSubeGuncelle
            // 
            this.btnSubeGuncelle.Location = new System.Drawing.Point(229, 177);
            this.btnSubeGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubeGuncelle.Name = "btnSubeGuncelle";
            this.btnSubeGuncelle.Size = new System.Drawing.Size(208, 45);
            this.btnSubeGuncelle.TabIndex = 31;
            this.btnSubeGuncelle.Text = "ŞUBE GÜNCELLE";
            this.btnSubeGuncelle.UseVisualStyleBackColor = true;
            this.btnSubeGuncelle.Click += new System.EventHandler(this.btnSubeGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Şube Koordinatörü:";
            // 
            // cmbSubeKoordinatoru
            // 
            this.cmbSubeKoordinatoru.FormattingEnabled = true;
            this.cmbSubeKoordinatoru.Location = new System.Drawing.Point(149, 53);
            this.cmbSubeKoordinatoru.Name = "cmbSubeKoordinatoru";
            this.cmbSubeKoordinatoru.Size = new System.Drawing.Size(160, 26);
            this.cmbSubeKoordinatoru.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şube Adresi:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Şube Telefon";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Şube Mail";
            this.columnHeader3.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Şube Koordinatörü";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Şube Adı";
            this.columnHeader1.Width = 147;
            // 
            // lstSubeBilgileri
            // 
            this.lstSubeBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSubeBilgileri.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstSubeBilgileri.FullRowSelect = true;
            this.lstSubeBilgileri.GridLines = true;
            this.lstSubeBilgileri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSubeBilgileri.HideSelection = false;
            this.lstSubeBilgileri.Location = new System.Drawing.Point(12, 229);
            this.lstSubeBilgileri.Name = "lstSubeBilgileri";
            this.lstSubeBilgileri.Size = new System.Drawing.Size(641, 235);
            this.lstSubeBilgileri.TabIndex = 30;
            this.lstSubeBilgileri.UseCompatibleStateImageBehavior = false;
            this.lstSubeBilgileri.View = System.Windows.Forms.View.Details;
            this.lstSubeBilgileri.SelectedIndexChanged += new System.EventHandler(this.lstSubeBilgileri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Şube Adı:";
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(149, 22);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(160, 25);
            this.txtSubeAdi.TabIndex = 18;
            // 
            // btnSubeEkle
            // 
            this.btnSubeEkle.Location = new System.Drawing.Point(13, 177);
            this.btnSubeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Size = new System.Drawing.Size(208, 45);
            this.btnSubeEkle.TabIndex = 28;
            this.btnSubeEkle.Text = "ŞUBE EKLE";
            this.btnSubeEkle.UseVisualStyleBackColor = true;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
            // 
            // grpSubeBilgileri
            // 
            this.grpSubeBilgileri.Controls.Add(this.label4);
            this.grpSubeBilgileri.Controls.Add(this.txtSubeTelefon);
            this.grpSubeBilgileri.Controls.Add(this.label3);
            this.grpSubeBilgileri.Controls.Add(this.txtSubeMaili);
            this.grpSubeBilgileri.Controls.Add(this.txtSubeAdresi);
            this.grpSubeBilgileri.Controls.Add(this.label7);
            this.grpSubeBilgileri.Controls.Add(this.cmbSubeKoordinatoru);
            this.grpSubeBilgileri.Controls.Add(this.label2);
            this.grpSubeBilgileri.Controls.Add(this.label1);
            this.grpSubeBilgileri.Controls.Add(this.txtSubeAdi);
            this.grpSubeBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpSubeBilgileri.Name = "grpSubeBilgileri";
            this.grpSubeBilgileri.Size = new System.Drawing.Size(641, 158);
            this.grpSubeBilgileri.TabIndex = 29;
            this.grpSubeBilgileri.TabStop = false;
            this.grpSubeBilgileri.Text = "Şube Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Şube Telefon:";
            // 
            // txtSubeTelefon
            // 
            this.txtSubeTelefon.Location = new System.Drawing.Point(149, 116);
            this.txtSubeTelefon.Name = "txtSubeTelefon";
            this.txtSubeTelefon.Size = new System.Drawing.Size(160, 25);
            this.txtSubeTelefon.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Şube Mail:";
            // 
            // txtSubeMaili
            // 
            this.txtSubeMaili.Location = new System.Drawing.Point(149, 85);
            this.txtSubeMaili.Name = "txtSubeMaili";
            this.txtSubeMaili.Size = new System.Drawing.Size(160, 25);
            this.txtSubeMaili.TabIndex = 29;
            // 
            // txtSubeAdresi
            // 
            this.txtSubeAdresi.Location = new System.Drawing.Point(440, 22);
            this.txtSubeAdresi.Multiline = true;
            this.txtSubeAdresi.Name = "txtSubeAdresi";
            this.txtSubeAdresi.Size = new System.Drawing.Size(195, 119);
            this.txtSubeAdresi.TabIndex = 28;
            // 
            // SubeEkleGuncelleSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 483);
            this.Controls.Add(this.btnSubeSil);
            this.Controls.Add(this.btnSubeGuncelle);
            this.Controls.Add(this.lstSubeBilgileri);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.grpSubeBilgileri);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubeEkleGuncelleSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SubeEkleGuncelleSilForm";
            this.Load += new System.EventHandler(this.SubeEkleGuncelleSilForm_Load);
            this.grpSubeBilgileri.ResumeLayout(false);
            this.grpSubeBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubeSil;
        private System.Windows.Forms.Button btnSubeGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubeKoordinatoru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstSubeBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.GroupBox grpSubeBilgileri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubeTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubeMaili;
        private System.Windows.Forms.TextBox txtSubeAdresi;
    }
}