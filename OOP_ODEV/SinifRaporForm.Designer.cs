namespace OOP_ODEV
{
    partial class SinifRaporForm
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
            this.grpSinifRaporu = new System.Windows.Forms.GroupBox();
            this.btnPDFKaydet = new System.Windows.Forms.Button();
            this.lblEgitmen = new System.Windows.Forms.Label();
            this.lblOgrenciSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKalanDersSaati = new System.Windows.Forms.Label();
            this.lblYapilanDersSaati = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSinifListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSinifRaporSubeSec = new System.Windows.Forms.ComboBox();
            this.cmbSinifRaporSinifSec = new System.Windows.Forms.ComboBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.grpSinifRaporu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSinifRaporu
            // 
            this.grpSinifRaporu.Controls.Add(this.btnPDFKaydet);
            this.grpSinifRaporu.Controls.Add(this.lblEgitmen);
            this.grpSinifRaporu.Controls.Add(this.lblOgrenciSayisi);
            this.grpSinifRaporu.Controls.Add(this.label7);
            this.grpSinifRaporu.Controls.Add(this.label8);
            this.grpSinifRaporu.Controls.Add(this.lblKalanDersSaati);
            this.grpSinifRaporu.Controls.Add(this.lblYapilanDersSaati);
            this.grpSinifRaporu.Controls.Add(this.label4);
            this.grpSinifRaporu.Controls.Add(this.label3);
            this.grpSinifRaporu.Controls.Add(this.lvSinifListesi);
            this.grpSinifRaporu.Location = new System.Drawing.Point(12, 105);
            this.grpSinifRaporu.Name = "grpSinifRaporu";
            this.grpSinifRaporu.Size = new System.Drawing.Size(644, 474);
            this.grpSinifRaporu.TabIndex = 0;
            this.grpSinifRaporu.TabStop = false;
            this.grpSinifRaporu.Text = "Sınıf Raporu";
            // 
            // btnPDFKaydet
            // 
            this.btnPDFKaydet.Image = global::OOP_ODEV.Properties.Resources.PDF_icon2;
            this.btnPDFKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDFKaydet.Location = new System.Drawing.Point(461, 21);
            this.btnPDFKaydet.Name = "btnPDFKaydet";
            this.btnPDFKaydet.Size = new System.Drawing.Size(172, 64);
            this.btnPDFKaydet.TabIndex = 22;
            this.btnPDFKaydet.Text = "PDF OLARAK KAYDET";
            this.btnPDFKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDFKaydet.UseVisualStyleBackColor = true;
            this.btnPDFKaydet.Click += new System.EventHandler(this.btnPDFKaydet_Click);
            // 
            // lblEgitmen
            // 
            this.lblEgitmen.AutoSize = true;
            this.lblEgitmen.Location = new System.Drawing.Point(336, 67);
            this.lblEgitmen.Name = "lblEgitmen";
            this.lblEgitmen.Size = new System.Drawing.Size(38, 18);
            this.lblEgitmen.TabIndex = 14;
            this.lblEgitmen.Text = "?????";
            // 
            // lblOgrenciSayisi
            // 
            this.lblOgrenciSayisi.AutoSize = true;
            this.lblOgrenciSayisi.Location = new System.Drawing.Point(375, 21);
            this.lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            this.lblOgrenciSayisi.Size = new System.Drawing.Size(38, 18);
            this.lblOgrenciSayisi.TabIndex = 13;
            this.lblOgrenciSayisi.Text = "?????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Eğitmen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Öğrenci Sayısı:";
            // 
            // lblKalanDersSaati
            // 
            this.lblKalanDersSaati.AutoSize = true;
            this.lblKalanDersSaati.Location = new System.Drawing.Point(166, 67);
            this.lblKalanDersSaati.Name = "lblKalanDersSaati";
            this.lblKalanDersSaati.Size = new System.Drawing.Size(38, 18);
            this.lblKalanDersSaati.TabIndex = 10;
            this.lblKalanDersSaati.Text = "?????";
            // 
            // lblYapilanDersSaati
            // 
            this.lblYapilanDersSaati.AutoSize = true;
            this.lblYapilanDersSaati.Location = new System.Drawing.Point(166, 21);
            this.lblYapilanDersSaati.Name = "lblYapilanDersSaati";
            this.lblYapilanDersSaati.Size = new System.Drawing.Size(38, 18);
            this.lblYapilanDersSaati.TabIndex = 9;
            this.lblYapilanDersSaati.Text = "?????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kalan Ders Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yapılan Ders Saati:";
            // 
            // lvSinifListesi
            // 
            this.lvSinifListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSinifListesi.GridLines = true;
            this.lvSinifListesi.HideSelection = false;
            this.lvSinifListesi.Location = new System.Drawing.Point(16, 100);
            this.lvSinifListesi.Name = "lvSinifListesi";
            this.lvSinifListesi.Size = new System.Drawing.Size(617, 362);
            this.lvSinifListesi.TabIndex = 0;
            this.lvSinifListesi.TileSize = new System.Drawing.Size(1, 1);
            this.lvSinifListesi.UseCompatibleStateImageBehavior = false;
            this.lvSinifListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra No";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Adı Soyadı";
            this.columnHeader2.Width = 234;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Katıldığı Ders Saati";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Devam Durumu (%)";
            this.columnHeader4.Width = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şube Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınıf Seç:";
            // 
            // cmbSinifRaporSubeSec
            // 
            this.cmbSinifRaporSubeSec.FormattingEnabled = true;
            this.cmbSinifRaporSubeSec.Location = new System.Drawing.Point(102, 26);
            this.cmbSinifRaporSubeSec.Name = "cmbSinifRaporSubeSec";
            this.cmbSinifRaporSubeSec.Size = new System.Drawing.Size(196, 26);
            this.cmbSinifRaporSubeSec.TabIndex = 3;
            this.cmbSinifRaporSubeSec.SelectedIndexChanged += new System.EventHandler(this.cmbSinifRaporSubeSec_SelectedIndexChanged);
            // 
            // cmbSinifRaporSinifSec
            // 
            this.cmbSinifRaporSinifSec.FormattingEnabled = true;
            this.cmbSinifRaporSinifSec.Location = new System.Drawing.Point(102, 63);
            this.cmbSinifRaporSinifSec.Name = "cmbSinifRaporSinifSec";
            this.cmbSinifRaporSinifSec.Size = new System.Drawing.Size(196, 26);
            this.cmbSinifRaporSinifSec.TabIndex = 4;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(316, 26);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(152, 63);
            this.btnFiltrele.TabIndex = 5;
            this.btnFiltrele.Text = "FİLTRELE";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // SinifRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 583);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.cmbSinifRaporSinifSec);
            this.Controls.Add(this.cmbSinifRaporSubeSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSinifRaporu);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SinifRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SinifRaporForm";
            this.Load += new System.EventHandler(this.SinifRaporForm_Load);
            this.grpSinifRaporu.ResumeLayout(false);
            this.grpSinifRaporu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSinifRaporu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSinifListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSinifRaporSubeSec;
        private System.Windows.Forms.ComboBox cmbSinifRaporSinifSec;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label lblEgitmen;
        private System.Windows.Forms.Label lblOgrenciSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKalanDersSaati;
        private System.Windows.Forms.Label lblYapilanDersSaati;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnPDFKaydet;
    }
}