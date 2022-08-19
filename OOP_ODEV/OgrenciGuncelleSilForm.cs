using DAL;
using DATA;
using OOP_ODEV.Concretes.OgrenciC;
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
    public partial class OgrenciGuncelleSilForm : Form
    {
        Context db;
        Koordinator koordinator;
        public OgrenciGuncelleSilForm(Koordinator koordinator1)
        {
            koordinator = koordinator1;
            db = new Context();
            InitializeComponent();
        }

        private void OgrenciGuncelleSilForm_Load(object sender, EventArgs e)
        {
            lblOgrenciSubeAdi.Text = koordinator.Sube.SubeAdi;         
            cmbOgrenciSinifi.DataSource = db.Siniflar.Where(x => x.SubeID == koordinator.SubeID && x.IsActive == true).ToList();
            cmbSinifaGoreAra.DataSource = db.Siniflar.Where(x => x.SubeID == koordinator.SubeID && x.IsActive == true).ToList();
            

        }
        Ogrenci seciliOgrenci;
        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedItems.Count > 0)
            {
                seciliOgrenci = lstOgrenciler.SelectedItems[0].Tag as Ogrenci;
                txtOgrenciAdi.Text = seciliOgrenci.Adi;
                txtOgrenciSoyadi.Text = seciliOgrenci.Soyadi;
                txtOgrenciCepTelefonu.Text = seciliOgrenci.CepTelefonu;
                txtOgrenciMailAdresi.Text = seciliOgrenci.Email;
                dtOgrenciDTarihi.Value = seciliOgrenci.DogumTarihi;
                cmbOgrenciSinifi.Text = seciliOgrenci.SinifKodu;

            }
        }
        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (true) // Bos alan kontrolü
            {
                seciliOgrenci.Adi = txtOgrenciAdi.Text;
                seciliOgrenci.SinifKodu = cmbOgrenciSinifi.Text;
                seciliOgrenci.Soyadi = txtOgrenciSoyadi.Text;
                seciliOgrenci.DogumTarihi = dtOgrenciDTarihi.Value;
                seciliOgrenci.Email = txtOgrenciMailAdresi.Text;
                new OgrenciGuncelle(seciliOgrenci);
                Listele();
                MessageBox.Show("BAŞARI İLE KAYDEDİLDİ");

            }
            else
            {
                MessageBox.Show("KAYDEDİLEMEDİ");
            }          
        }
        void Listele()
        {
            lstOgrenciler.Items.Clear();
            foreach (var item in db.Ogrenciler.Where(x=>x.IsActive == true).ToList())
            {               
                ListViewItem lst = new ListViewItem();
                lst.Text = item.Adi;
                lst.SubItems.Add(item.Soyadi);
                lst.SubItems.Add(item.CepTelefonu);
                lst.SubItems.Add(item.Email);
                lst.SubItems.Add(item.SinifKodu);
                lst.SubItems.Add(lblOgrenciSubeAdi.Text);
                lst.Tag = item;
                lstOgrenciler.Items.Add(lst);                
            }
        }
        private void btnOgrenciAramaYap_Click(object sender, EventArgs e)
        {
            lstOgrenciler.Items.Clear();
            if (txtAdaGoreAra.Text == "" && cmbSinifaGoreAra.SelectedItem != null)
            {
                foreach (var item in db.Ogrenciler.Where(x => x.SinifKodu == cmbSinifaGoreAra.Text && x.IsActive == true).ToList())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.Adi;
                    lst.SubItems.Add(item.Soyadi);
                    lst.SubItems.Add(item.CepTelefonu);
                    lst.SubItems.Add(item.Email);
                    lst.SubItems.Add(item.SinifKodu);
                    lst.SubItems.Add(lblOgrenciSubeAdi.Text);
                    lst.Tag = item;
                    lstOgrenciler.Items.Add(lst);
                }
            }
            else if (txtAdaGoreAra.Text != "" && cmbSinifaGoreAra.Text == "")
            {
                foreach (var item in db.Ogrenciler.Where(x => x.IsActive == true && (x.Adi.Contains(txtAdaGoreAra.Text)) || (x.Soyadi.Contains(txtAdaGoreAra.Text))).ToList())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.Adi;
                    lst.SubItems.Add(item.Soyadi);
                    lst.SubItems.Add(item.CepTelefonu);
                    lst.SubItems.Add(item.Email);
                    lst.SubItems.Add(item.SinifKodu);
                    lst.SubItems.Add(lblOgrenciSubeAdi.Text);
                    lst.Tag = item;
                    lstOgrenciler.Items.Add(lst);
                }
            }
            else if (txtAdaGoreAra.Text != "" && cmbSinifaGoreAra.Text != "")
            {
                foreach (var item in db.Ogrenciler.Where(x => x.IsActive == true && (x.Adi.Contains(txtAdaGoreAra.Text)) || (x.Soyadi.Contains(txtAdaGoreAra.Text)) && x.SinifKodu == cmbSinifaGoreAra.Text).ToList())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.Adi;
                    lst.SubItems.Add(item.Soyadi);
                    lst.SubItems.Add(item.CepTelefonu);
                    lst.SubItems.Add(item.Email);
                    lst.SubItems.Add(item.SinifKodu);
                    lst.SubItems.Add(lblOgrenciSubeAdi.Text);
                    lst.Tag = item;
                    lstOgrenciler.Items.Add(lst);
                }
            }
            else if (txtAdaGoreAra.Text == "" && cmbSinifaGoreAra.Text == "")
            {
                MessageBox.Show("ARANCAK BİR ANAHTAR GİRİNİZ");
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            new OgrenciSil(seciliOgrenci.OgrenciID);            
            Listele();       
        }
    }
}
