namespace OOP_ODEV
{
    partial class EgitmenForm
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
            this.msEgitmenForm = new System.Windows.Forms.MenuStrip();
            this.tsmYoklamaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYoklamaGir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRaporIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.msEgitmenForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEgitmenForm
            // 
            this.msEgitmenForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.msEgitmenForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYoklamaIslemleri,
            this.tsmRaporIslemleri});
            this.msEgitmenForm.Location = new System.Drawing.Point(0, 0);
            this.msEgitmenForm.Name = "msEgitmenForm";
            this.msEgitmenForm.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.msEgitmenForm.Size = new System.Drawing.Size(672, 29);
            this.msEgitmenForm.TabIndex = 1;
            this.msEgitmenForm.Text = "menuStrip1";
            // 
            // tsmYoklamaIslemleri
            // 
            this.tsmYoklamaIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYoklamaGir});
            this.tsmYoklamaIslemleri.Name = "tsmYoklamaIslemleri";
            this.tsmYoklamaIslemleri.Size = new System.Drawing.Size(132, 21);
            this.tsmYoklamaIslemleri.Text = "Yoklama İşlemleri";
            // 
            // tsmYoklamaGir
            // 
            this.tsmYoklamaGir.Name = "tsmYoklamaGir";
            this.tsmYoklamaGir.Size = new System.Drawing.Size(180, 22);
            this.tsmYoklamaGir.Text = "Yoklama Gir";
            this.tsmYoklamaGir.Click += new System.EventHandler(this.tsmYoklamaGir_Click);
            // 
            // tsmRaporIslemleri
            // 
            this.tsmRaporIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSinifRaporu});
            this.tsmRaporIslemleri.Name = "tsmRaporIslemleri";
            this.tsmRaporIslemleri.Size = new System.Drawing.Size(119, 21);
            this.tsmRaporIslemleri.Text = "Rapor İşlemleri";
            
            // 
            // tsmSinifRaporu
            // 
            this.tsmSinifRaporu.Name = "tsmSinifRaporu";
            this.tsmSinifRaporu.Size = new System.Drawing.Size(180, 22);
            this.tsmSinifRaporu.Text = "Sınıf Raporu";
            this.tsmSinifRaporu.Click += new System.EventHandler(this.tsmSinifRaporu_Click);
            // 
            // EgitmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 407);
            this.Controls.Add(this.msEgitmenForm);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EgitmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EgitmenForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EgitmenForm_FormClosed);
            this.Load += new System.EventHandler(this.EgitmenForm_Load);
            this.msEgitmenForm.ResumeLayout(false);
            this.msEgitmenForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEgitmenForm;
        private System.Windows.Forms.ToolStripMenuItem tsmRaporIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmYoklamaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmYoklamaGir;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifRaporu;
    }
}