using DAL;
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
    public partial class KoordinatorForm : Form
    {
        Context db;
        Koordinator koordinator1;
        Form1 anaForm;
        public KoordinatorForm(Form1 frm, Koordinator koordinator)
        {
            db = new Context();
            koordinator1 = koordinator;
            anaForm = frm;
            InitializeComponent();
        }
        private void KoordinatorForm_Load(object sender, EventArgs e)
        {
            ChildForm(new SubeRaporForm(koordinator1));
        }
        private void tsmEgitmenEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new KullaniciEkleForm(koordinator1));
        }

        private void tsmEgitmenGuncelleSil_Click(object sender, EventArgs e)
        {
            ChildForm(new KullaniciGuncelleSilForm());
        }

        private void tsmSinifEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new SinifEkleGuncelleSilForm(koordinator1));
        }

        private void tsmSubeRaporu_Click(object sender, EventArgs e)
        {
            ChildForm(new SubeRaporForm(koordinator1));
        }
        private void tsmSinifRaporu_Click(object sender, EventArgs e)
        {
            ChildForm(new SinifRaporForm(koordinator1));
        }
        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new OgrenciEkleForm(koordinator1));
        }
        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new OgrenciGuncelleSilForm(koordinator1));
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
                    item.Show();
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

        private void KoordinatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
            // Kontrollerden textboxları temizle.

        }
    }
}
