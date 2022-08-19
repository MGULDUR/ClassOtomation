namespace OOP_ODEV
{
    partial class KoordinatorForm
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
            this.msKoordinatorForm = new System.Windows.Forms.MenuStrip();
            this.tsmEgitmenIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEgitmenEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEgitmenGuncelleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifGuncellemeSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRaporIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubeRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.msKoordinatorForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msKoordinatorForm
            // 
            this.msKoordinatorForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.msKoordinatorForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEgitmenIslemleri,
            this.tsmSinifIslemleri,
            this.tsmRaporIslemleri});
            this.msKoordinatorForm.Location = new System.Drawing.Point(0, 0);
            this.msKoordinatorForm.Name = "msKoordinatorForm";
            this.msKoordinatorForm.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.msKoordinatorForm.Size = new System.Drawing.Size(800, 27);
            this.msKoordinatorForm.TabIndex = 1;
            this.msKoordinatorForm.Text = "menuStrip1";
            // 
            // tsmEgitmenIslemleri
            // 
            this.tsmEgitmenIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEgitmenEkle,
            this.tsmEgitmenGuncelleSil});
            this.tsmEgitmenIslemleri.Name = "tsmEgitmenIslemleri";
            this.tsmEgitmenIslemleri.Size = new System.Drawing.Size(132, 21);
            this.tsmEgitmenIslemleri.Text = "Eğitmen İşlemleri";
            // 
            // tsmEgitmenEkle
            // 
            this.tsmEgitmenEkle.Name = "tsmEgitmenEkle";
            this.tsmEgitmenEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEgitmenEkle.Text = "Ekle";
            // 
            // tsmEgitmenGuncelleSil
            // 
            this.tsmEgitmenGuncelleSil.Name = "tsmEgitmenGuncelleSil";
            this.tsmEgitmenGuncelleSil.Size = new System.Drawing.Size(180, 22);
            this.tsmEgitmenGuncelleSil.Text = "Güncelle / Sil";
            // 
            // tsmSinifIslemleri
            // 
            this.tsmSinifIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSinifEkle,
            this.tsmSinifGuncellemeSil});
            this.tsmSinifIslemleri.Name = "tsmSinifIslemleri";
            this.tsmSinifIslemleri.Size = new System.Drawing.Size(108, 21);
            this.tsmSinifIslemleri.Text = "Sınıf İşlemleri";
            // 
            // tsmSinifEkle
            // 
            this.tsmSinifEkle.Name = "tsmSinifEkle";
            this.tsmSinifEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmSinifEkle.Text = "Ekle";
            // 
            // tsmSinifGuncellemeSil
            // 
            this.tsmSinifGuncellemeSil.Name = "tsmSinifGuncellemeSil";
            this.tsmSinifGuncellemeSil.Size = new System.Drawing.Size(180, 22);
            this.tsmSinifGuncellemeSil.Text = "Güncelle / Sil";
            // 
            // tsmRaporIslemleri
            // 
            this.tsmRaporIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSubeRaporu,
            this.tsmSinifRaporu});
            this.tsmRaporIslemleri.Name = "tsmRaporIslemleri";
            this.tsmRaporIslemleri.Size = new System.Drawing.Size(117, 21);
            this.tsmRaporIslemleri.Text = "Rapor İşlemleri";
            // 
            // tsmSubeRaporu
            // 
            this.tsmSubeRaporu.Name = "tsmSubeRaporu";
            this.tsmSubeRaporu.Size = new System.Drawing.Size(180, 22);
            this.tsmSubeRaporu.Text = "Şube Raporu";
            // 
            // tsmSinifRaporu
            // 
            this.tsmSinifRaporu.Name = "tsmSinifRaporu";
            this.tsmSinifRaporu.Size = new System.Drawing.Size(180, 22);
            this.tsmSinifRaporu.Text = "Sınıf Raporu";
            // 
            // KoordinatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msKoordinatorForm);
            this.Name = "KoordinatorForm";
            this.Text = "KoordinatorForm";
            this.msKoordinatorForm.ResumeLayout(false);
            this.msKoordinatorForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msKoordinatorForm;
        private System.Windows.Forms.ToolStripMenuItem tsmEgitmenIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmEgitmenEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEgitmenGuncelleSil;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifGuncellemeSil;
        private System.Windows.Forms.ToolStripMenuItem tsmRaporIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmSubeRaporu;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifRaporu;
    }
}