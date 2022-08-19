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
    public partial class YoklamaEkleForm : Form
    {
        Egitmen egitmen;
        Context db;
        public YoklamaEkleForm(Egitmen girisYapanEgitmen)
        {
            db = new Context();
            egitmen = girisYapanEgitmen;
            InitializeComponent();
        }

        private void YoklamaEkleForm_Load(object sender, EventArgs e)
        {
            btnYoklamaBul.Enabled = btnTumOgrencileriSec.Enabled = btnTumSecimleriKaldir.Enabled = btnYoklamaGir.Enabled = false;
            tlpYoklamaListesi.Visible = false;
            lblSubeAdi.Text = egitmen.Sube.SubeAdi;

            foreach (var item in db.SiniflarEgitmenler.Where(x => (x.EgitmenID == egitmen.EgitmenID) && (x.IsActive == true)).ToList())
            {
                cmbEgitmenSiniflar.Items.Add(item.SinifKodu);
            }
        }
        List<Ogrenci> siniftakiOgrenciler;
        private void btnYoklamaBul_Click(object sender, EventArgs e)
        {
            bool durum = false;
            Sinif seciliSinif = db.Siniflar.FirstOrDefault(x => x.SinifKodu == cmbEgitmenSiniflar.Text);
            switch (dtTarih.Value.DayOfWeek.ToString())
            {
                case "Monday":
                    if (dtTarih.Value.DayOfWeek.ToString() == "Monday" && seciliSinif.Pazartesi == true) durum = true;
                    else durum = false;
                    break;
                case "Tuesday":
                    if (seciliSinif.Sali == true) durum = true;
                    else durum = false;
                    break;
                case "Wednesday":
                    if (seciliSinif.Carsamba == true) durum = true;
                    else durum = false;
                    break;
                case "Thursday":
                    if (seciliSinif.Persembe == true) durum = true;
                    else durum = false;
                    break;
                case "Friday":
                    if (seciliSinif.Cuma == true) durum = true;
                    else durum = false;
                    break;
                case "Saturday":
                    if (seciliSinif.Cumartesi == true) durum = true;
                    else durum = false;
                    break;
                case "Sunday":
                    if (seciliSinif.Pazartesi == true) durum = true;
                    else durum = false;
                    break;
            }

            if (durum == false) MessageBox.Show("Güne ait ders yok");
            else
            {
                // 16 x 6
                if (db.Ogrenciler.Where(x => x.SinifKodu == cmbEgitmenSiniflar.Text).ToList().Count() < 1)
                {
                    MessageBox.Show("Sınıfta öğrenci bulunamadı.");
                    btnYoklamaGir.Enabled = false;
                }
                else btnYoklamaGir.Enabled = true;

                tlpYoklamaListesi.Visible = true;
                tlpYoklamaListesi.Controls.Clear();

                tlpYoklamaListesi.Controls.Add(new Label() { Text = "ÖĞRENCİ ADI SOYADI", Width = 450 }, 0, 0);
                tlpYoklamaListesi.Controls.Add(new Label() { Text = "DERS 1" }, 1, 0);
                tlpYoklamaListesi.Controls.Add(new Label() { Text = "DERS 2" }, 2, 0);
                tlpYoklamaListesi.Controls.Add(new Label() { Text = "DERS 3" }, 3, 0);
                tlpYoklamaListesi.Controls.Add(new Label() { Text = "DERS 4" }, 4, 0);
                tlpYoklamaListesi.Controls.Add(new Label() { Text = "DERS 5" }, 5, 0);

                Label lbl;
                int ogr = 1;
                siniftakiOgrenciler = new List<Ogrenci>();
                foreach (Ogrenci item in db.Ogrenciler.Where(x => x.SinifKodu == cmbEgitmenSiniflar.Text).ToList())
                {
                    siniftakiOgrenciler.Add(item);

                    lbl = new Label();
                    lbl.Text = $"{item.Adi} {item.Soyadi}";
                    lbl.Width = 450;
                    tlpYoklamaListesi.Controls.Add(lbl, 0, ogr);

                    int gunlukEgitimSaati = db.Siniflar.FirstOrDefault(x => x.SinifKodu == cmbEgitmenSiniflar.Text).GunlukEgitimSaati;
                    for (int t = 1; t < gunlukEgitimSaati + 1; t++)
                    {
                        switch (t)
                        {
                            case 1:
                                if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) != null)
                                {
                                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)).Ders1 == true)
                                    {
                                        tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = true }, t, ogr);
                                    }
                                    else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                }
                                else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                break;

                            case 2:
                                if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) != null)
                                {
                                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)).Ders2 == true)
                                    {
                                        tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = true }, t, ogr);
                                    }
                                    else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                }
                                else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                break;

                            case 3:
                                if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) != null)
                                {
                                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)).Ders3 == true)
                                    {
                                        tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = true }, t, ogr);
                                    }
                                    else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                }
                                else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                break;

                            case 4:
                                if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) != null)
                                {
                                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)).Ders4 == true)
                                    {
                                        tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = true }, t, ogr);
                                    }
                                    else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                }
                                else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                break;

                            case 5:
                                if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) != null)
                                {
                                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)).Ders5 == true)
                                    {
                                        tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = true }, t, ogr);
                                    }
                                    else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                }
                                else tlpYoklamaListesi.Controls.Add(new CheckBox() { Name = $"chkOgrenci{item.OgrenciID}_{t}", Tag = item.OgrenciID, Checked = false }, t, ogr);
                                break;
                        }
                    }
                    ogr++;
                }
            }
        }

        private void btnTumOgrencileriSec_Click(object sender, EventArgs e)
        {
            foreach (Control item in tlpYoklamaListesi.Controls)
            {
                if (item is CheckBox) ((CheckBox)item).Checked = true;
            }
        }

        private void btnTumSecimleriKaldir_Click(object sender, EventArgs e)
        {
            foreach (Control item in tlpYoklamaListesi.Controls)
            {
                if (item is CheckBox) ((CheckBox)item).Checked = false;
            }
        }

        private void btnYoklamaGir_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Ogrenci item in siniftakiOgrenciler.ToList())
                {
                    if (db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == (db.Ogrenciler.FirstOrDefault(y => y.OgrenciID == item.OgrenciID)).OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year)) == null)
                    {
                        Yoklama yoklama = new Yoklama();
                        yoklama.OgrenciID = item.OgrenciID;
                        yoklama.YoklamaTarih = dtTarih.Value;
                        db.Yoklamalar.Add(yoklama);
                        db.SaveChanges();
                    }
                }


                foreach (Ogrenci item in siniftakiOgrenciler.ToList())
                {
                    db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Year == dtTarih.Value.Year) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Day == dtTarih.Value.Day)).Ders1 = false;
                    db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Year == dtTarih.Value.Year) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Day == dtTarih.Value.Day)).Ders2 = false;
                    db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Year == dtTarih.Value.Year) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Day == dtTarih.Value.Day)).Ders3 = false;
                    db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Year == dtTarih.Value.Year) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Day == dtTarih.Value.Day)).Ders4 = false;
                    db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == item.OgrenciID) && (x.YoklamaTarih.Year == dtTarih.Value.Year) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Day == dtTarih.Value.Day)).Ders5 = false;

                    db.SaveChanges();
                }



                List<CheckBox> YoklamaCheck = new List<CheckBox>();

                foreach (Control item in tlpYoklamaListesi.Controls)
                {
                    if (item is CheckBox)
                    {
                        if (((CheckBox)item).Checked)
                        {
                            YoklamaCheck.Add((CheckBox)item);
                        }
                    }
                }

                foreach (CheckBox item in YoklamaCheck.ToList())
                {
                    Yoklama mevcutOgrenciYoklama = db.Yoklamalar.FirstOrDefault(x => (x.OgrenciID == db.Ogrenciler.FirstOrDefault(y => y.OgrenciID == (int)item.Tag).OgrenciID) && (x.YoklamaTarih.Day == dtTarih.Value.Day) && (x.YoklamaTarih.Month == dtTarih.Value.Month) && (x.YoklamaTarih.Year == dtTarih.Value.Year));

                    if (item.Name.Last() == '1') mevcutOgrenciYoklama.Ders1 = true;
                    if (item.Name.Last() == '2') mevcutOgrenciYoklama.Ders2 = true;
                    if (item.Name.Last() == '3') mevcutOgrenciYoklama.Ders3 = true;
                    if (item.Name.Last() == '4') mevcutOgrenciYoklama.Ders4 = true;
                    if (item.Name.Last() == '5') mevcutOgrenciYoklama.Ders5 = true;
                    db.SaveChanges();

                }
                MessageBox.Show("İşlem başarılı");
                tlpYoklamaListesi.Controls.Clear();
                cmbEgitmenSiniflar.SelectedIndex = -1;
                btnYoklamaGir.Enabled = false;
                tlpYoklamaListesi.Visible = false;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen seçim yapın");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEgitmenSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEgitmenSiniflar.SelectedIndex == -1) btnYoklamaBul.Enabled = btnTumOgrencileriSec.Enabled = btnTumSecimleriKaldir.Enabled = false;
            else btnYoklamaBul.Enabled = btnTumOgrencileriSec.Enabled = btnTumSecimleriKaldir.Enabled = true;
        }
    }
}
