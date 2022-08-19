namespace OOP_ODEV
{
    partial class Form1
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
            this.grpGirisPaneli = new System.Windows.Forms.GroupBox();
            this.chkParolaGoster = new System.Windows.Forms.CheckBox();
            this.txtGirisParola = new System.Windows.Forms.TextBox();
            this.txtGirisMailAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.grpGirisPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGirisPaneli
            // 
            this.grpGirisPaneli.Controls.Add(this.chkParolaGoster);
            this.grpGirisPaneli.Controls.Add(this.txtGirisParola);
            this.grpGirisPaneli.Controls.Add(this.txtGirisMailAdresi);
            this.grpGirisPaneli.Controls.Add(this.label2);
            this.grpGirisPaneli.Controls.Add(this.label1);
            this.grpGirisPaneli.Controls.Add(this.btnGirisYap);
            this.grpGirisPaneli.Location = new System.Drawing.Point(13, 13);
            this.grpGirisPaneli.Name = "grpGirisPaneli";
            this.grpGirisPaneli.Size = new System.Drawing.Size(402, 170);
            this.grpGirisPaneli.TabIndex = 0;
            this.grpGirisPaneli.TabStop = false;
            this.grpGirisPaneli.Text = "GİRİŞ PANELİ";
            // 
            // chkParolaGoster
            // 
            this.chkParolaGoster.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkParolaGoster.Location = new System.Drawing.Point(128, 92);
            this.chkParolaGoster.Name = "chkParolaGoster";
            this.chkParolaGoster.Size = new System.Drawing.Size(132, 22);
            this.chkParolaGoster.TabIndex = 2;
            this.chkParolaGoster.Text = "Parolayı Göster";
            this.chkParolaGoster.UseVisualStyleBackColor = true;
            // 
            // txtGirisParola
            // 
            this.txtGirisParola.Location = new System.Drawing.Point(128, 60);
            this.txtGirisParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtGirisParola.Name = "txtGirisParola";
            this.txtGirisParola.Size = new System.Drawing.Size(248, 25);
            this.txtGirisParola.TabIndex = 1;
            // 
            // txtGirisMailAdresi
            // 
            this.txtGirisMailAdresi.Location = new System.Drawing.Point(128, 25);
            this.txtGirisMailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtGirisMailAdresi.Name = "txtGirisMailAdresi";
            this.txtGirisMailAdresi.Size = new System.Drawing.Size(248, 25);
            this.txtGirisMailAdresi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mail Adresi:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(128, 121);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(248, 32);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 195);
            this.Controls.Add(this.grpGirisPaneli);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpGirisPaneli.ResumeLayout(false);
            this.grpGirisPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirisPaneli;
        private System.Windows.Forms.CheckBox chkParolaGoster;
        private System.Windows.Forms.TextBox txtGirisParola;
        private System.Windows.Forms.TextBox txtGirisMailAdresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

