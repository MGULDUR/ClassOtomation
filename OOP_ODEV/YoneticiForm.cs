using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class YoneticiForm : Form
    {
        Form1 anaForm;
        public YoneticiForm(Form1 frm)
        {
            anaForm = frm;
            InitializeComponent();
        }
        public Yonetici gelenYonetici;
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hoşgeldin {gelenYonetici} - {gelenYonetici.Gorevi}";
            ChildForm(new GenelRaporForm());
        }

        private void tsmKullaniciEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new KullaniciEkleForm());
        }

        private void tsmKullaniciGuncelleSil_Click(object sender, EventArgs e)
        {
            ChildForm(new KullaniciGuncelleSilForm());
        }

        private void tsmSubeEkleGuncelleSil_Click(object sender, EventArgs e)
        {
            ChildForm(new SubeEkleGuncelleSilForm());
        }

        private void tsmEgitimEkleGuncellSil_Click(object sender, EventArgs e)
        {
            ChildForm(new EgitimEkleGuncelleSilForm());
        }

        private void tsmGenelRapor_Click(object sender, EventArgs e)
        {
            ChildForm(new GenelRaporForm());
        }

        private void tsmSubeRaporu_Click(object sender, EventArgs e)
        {
            ChildForm(new SubeRaporForm());
        }

        private void tsmSinifRaporu_Click(object sender, EventArgs e)
        {
            ChildForm(new SinifRaporForm());
        }

        private void YoneticiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        void ChildForm(Form child)
        {
            this.Width = child.Width + 50;
            this.Height = child.Height + 100;


            bool durum = false;

            foreach (Form item in MdiChildren)
            {
                if (item.Text == child.Text)
                {
                    durum = true;
                    item.Activate();
                }
                else
                {
                    item.Close();
                }
            }
            if (durum == false)
            {
                child.MdiParent = this;
                child.Show();
            }
        }
    }
}


