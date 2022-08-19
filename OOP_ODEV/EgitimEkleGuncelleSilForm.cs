using DAL;
using DATA;
using OOP_ODEV.Concretes.EgitimC;
using OOP_ODEV.Concretes.Genel;
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
    public partial class EgitimEkleGuncelleSilForm : Form
    {
        Context db;
        public EgitimEkleGuncelleSilForm()
        {
            db = new Context();
            InitializeComponent();
        }
        private void EgitimEkleGuncelleSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            if (BosAlanKontrol.EmptyAreaControl(grpEgitimBilgileri))
            {
                
            }
            else
            {
                new EgitimEkle(txtEgitimAdi.Text, txtEgitimAciklama.Text, (int)nmrDersSuresi.Value);
                Listele();
                Temizle.Clean(this.Controls);
                MessageBox.Show("BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
           

        }
        public void Listele()
        {
            lstEgitimListesi.Items.Clear();
            foreach (var item in db.Egitimler.Where(x => x.IsActive == true).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.EgitimAdi;
                lvi.SubItems.Add(item.EgitimSuresi.ToString());
                lvi.SubItems.Add(item.EgitimAciklamasi);
                lvi.Tag = item;
                lstEgitimListesi.Items.Add(lvi);
            }
        }

       
        Egitim egitims;
        private void lstEgitimListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEgitimListesi.SelectedItems.Count > 0)
            {
                egitims = lstEgitimListesi.SelectedItems[0].Tag as Egitim;
                txtEgitimAdi.Text = egitims.EgitimAdi;
                txtEgitimAciklama.Text = egitims.EgitimAciklamasi;
                nmrDersSuresi.Value = egitims.EgitimSuresi;
            }
        }

        private void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            egitims.EgitimAciklamasi = txtEgitimAciklama.Text;
            egitims.EgitimSuresi = (int)nmrDersSuresi.Value;
            egitims.EgitimAdi = txtEgitimAdi.Text;
            new EgitimGuncelle(egitims);
            Listele();
            Temizle.Clean(this.Controls);
        }

        private void btnEgitimSil_Click(object sender, EventArgs e)
        {
            if (lstEgitimListesi.SelectedItems.Count > 0)
            {
                new EgitimSil(((Egitim)lstEgitimListesi.SelectedItems[0].Tag).EgitimID);
                Temizle.Clean(this.Controls);
                Listele();
                MessageBox.Show("BAŞARILI BİR ŞEKİLDE SİLİNDİ");
            }
            else
            {
                MessageBox.Show("SİLİNECEK EĞİTİM SEÇİLMEDİ");
            }

        }
    }
}
