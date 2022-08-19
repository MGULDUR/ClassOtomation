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
    public partial class EgitmenForm : Form
    {
        Form1 anaForm;
        public Egitmen girisyapanegitmenn;
        public EgitmenForm(Form1 frm, Egitmen egitmen)
        {
            girisyapanegitmenn = egitmen;
            anaForm = frm;
            InitializeComponent();
        }

        private void EgitmenForm_Load(object sender, EventArgs e)
        {
            ChildForm(new YoklamaEkleForm(girisyapanegitmenn));
        }
        private void tsmYoklamaGir_Click(object sender, EventArgs e)
        {
            ChildForm(new YoklamaEkleForm(girisyapanegitmenn));
        }
        private void tsmSinifRaporu_Click(object sender, EventArgs e)
        {
            ChildForm(new SinifRaporForm());
        }
        private void EgitmenForm_FormClosed(object sender, FormClosedEventArgs e)
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
