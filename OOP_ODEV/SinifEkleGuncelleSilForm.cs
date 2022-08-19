using DAL;
using DATA;
using OOP_ODEV.Concretes.SınıfEgitimC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class SinifEkleGuncelleSilForm : Form
    {
        Context db;
        Koordinator koordinator;
        public SinifEkleGuncelleSilForm(Koordinator koordinator1)
        {
            db = new Context();
            koordinator = koordinator1;
            InitializeComponent();
        }

        private void SinifEkleGuncelleSilForm_Load(object sender, EventArgs e)
        {
            lblSubeAdi.Text = koordinator.Sube.SubeAdi;
            cmbSinifEgitim.DataSource = db.Egitimler.ToList();
            cmbSinifEgitim.Text = string.Empty;
            cmbSinifEgitmen.DataSource = db.Egitmenler.Where(x => x.SubeID == koordinator.SubeID).ToList();
            cmbSinifEgitmen.Text = string.Empty;
            dtSinifBitisTarihi.Enabled = false;
            SiniflariListele();


        }
        private void SiniflariListele()
        {
            lstSubeSiniflar.Items.Clear();
            foreach (Sinif item in db.Siniflar.Where(x => x.IsActive == true).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.SinifKodu;
                lvi.SubItems.Add(db.Egitimler.FirstOrDefault(x => x.EgitimID == item.EgitimID).EgitimAdi);
                lvi.SubItems.Add(item.EgitimBaslangic.ToShortDateString());
                lvi.SubItems.Add(item.EgitimBitis.ToShortDateString());
                if (db.Egitmenler.FirstOrDefault(x => x.EgitmenID == db.SiniflarEgitmenler.FirstOrDefault(y => y.SinifKodu == item.SinifKodu).EgitmenID) != null)
                {
                    lvi.SubItems.Add(db.Egitmenler.FirstOrDefault(x => x.EgitmenID == db.SiniflarEgitmenler.FirstOrDefault(y => y.SinifKodu == item.SinifKodu).EgitmenID).Adi);
                }
                lvi.Tag = item;
                lstSubeSiniflar.Items.Add(lvi);

            }
        }
        private void btnSinifEkle_Click(object sender, EventArgs e)
        {

            #region dene2
            int egitimGunleri = 0; // Pzt- Salı vb
            int birGunlukEgitimSaati = (int)nmrEgitimSuresi.Value;
            int totalEgitimSaati = db.Egitimler.FirstOrDefault(x => x.EgitimAdi == cmbSinifEgitim.Text).EgitimSuresi; // 2
            TimeSpan kalanGun = dtSinifBaslangicTarihi.Value - dtSinifBitisTarihi.Value;
            double ikiTarihArasindakiGun = kalanGun.TotalDays;
            List<string> lessonDays = new List<string>();
            foreach (var item in chkLbxEgitimGunleri.CheckedItems)
            {
                lessonDays.Add(item.ToString());
            }

            for (int i = 0; i < chkLbxEgitimGunleri.CheckedItems.Count; i++)
            {
                egitimGunleri++;
            }

            int haftaEgitimSaat = egitimGunleri * birGunlukEgitimSaati; // => Bir hafta boyunca toplam eğitim saati

            int kacHafta = totalEgitimSaati / haftaEgitimSaat; // Toplam eğitim haftasını buluyoruz

            double toplamHafta = totalEgitimSaati / (egitimGunleri * birGunlukEgitimSaati);
            int kalanGunler = totalEgitimSaati % (egitimGunleri * birGunlukEgitimSaati);

            #endregion
            #region Tarık Deneme ++
            string takvimilkgun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)dtSinifBaslangicTarihi.Value.DayOfWeek];
            string takvimsongun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)dtSinifBitisTarihi.Value.DayOfWeek];

            if (takvimilkgun == lessonDays.First())
            {
                if (totalEgitimSaati % haftaEgitimSaat == 0)
                {
                    toplamHafta = 7 * (toplamHafta - 1);
                    int sonGun = 0;
                    switch (lessonDays.Last())
                    {

                        case "Pazartesi":
                            sonGun = 1;
                            break;
                        case "Salı":
                            sonGun = 2;
                            break;
                        case "Çarşamba":
                            sonGun = 3;
                            break;
                        case "Perşembe":
                            sonGun = 4;
                            break;
                        case "Cuma":
                            sonGun = 5;
                            break;
                        case "Cumartesi":
                            sonGun = 6;
                            break;
                        case "Pazar":
                            sonGun = 7;
                            break;
                    }

                    int x = (int)(toplamHafta + sonGun);

                    dtSinifBitisTarihi.Value = dtSinifBaslangicTarihi.Value.AddDays(Convert.ToDouble(x - 1));

                    foreach (var item in chkLbxEgitimGunleri.CheckedItems)
                    {

                    }
                    new SinifEgitimEkle(txtSinifKodu.Text,
                                            dtSinifBaslangicTarihi.Value,
                                            dtSinifBitisTarihi.Value,
                                            (int)nmrEgitimSuresi.Value,
                                            (int)koordinator.SubeID,
                                            ((Egitim)cmbSinifEgitim.SelectedItem).EgitimID,
                                            txtSinifBaslangicSaati.Text,
                                            txtSinifBitisSaati.Text,
                                            (cmbSinifEgitmen.SelectedItem as Egitmen).EgitmenID, lessonDays
                                            );
                    MessageBox.Show("BAŞARILI BİR ŞEKİLDE EKLENDİ");
                    SiniflariListele();

                }
                else
                {
                    if (takvimilkgun == lessonDays.First())
                    {

                        int y = 0;
                        int sonGun = 0;
                        y = (int)(10 * (toplamHafta));
                        int artansaat = (int)(totalEgitimSaati - y);

                        if (birGunlukEgitimSaati > artansaat)
                        {
                            switch (lessonDays.First())
                            {

                                case "Pazartesi":
                                    sonGun = 1;
                                    break;
                                case "Salı":
                                    sonGun = 2;
                                    break;
                                case "Çarşamba":
                                    sonGun = 3;
                                    break;
                                case "Perşembe":
                                    sonGun = 4;
                                    break;
                                case "Cuma":
                                    sonGun = 5;
                                    break;
                                case "Cumartesi":
                                    sonGun = 6;
                                    break;
                                case "Pazar":
                                    sonGun = 7;
                                    break;
                            }

                            int sonuc = (int)((7 * toplamHafta) + sonGun);
                            dtSinifBitisTarihi.Value = dtSinifBaslangicTarihi.Value.AddDays(Convert.ToDouble(sonuc - 1));

                            new SinifEgitimEkle(txtSinifKodu.Text,
                                            dtSinifBaslangicTarihi.Value,
                                            dtSinifBitisTarihi.Value,
                                            (int)nmrEgitimSuresi.Value,
                                            (int)koordinator.SubeID,
                                            ((Egitim)cmbSinifEgitim.SelectedItem).EgitimID,
                                            txtSinifBaslangicSaati.Text,
                                            txtSinifBitisSaati.Text,
                                            (cmbSinifEgitmen.SelectedItem as Egitmen).EgitmenID, lessonDays
                                            );
                            MessageBox.Show("BAŞARILI BİR ŞEKİLDE EKLENDİ");
                            SiniflariListele();


                        }
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN EĞİTİM BAŞLANGIÇ TARİHİNİ " + lessonDays.First() + " OLARAK AYARLAYINIZ");
                    }
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN EĞİTİM BAŞLANGIÇ TARİHİNİ " + lessonDays.First() + " OLARAK AYARLAYINIZ");
            };
            #endregion




        }
        Sinif sinif;
        private void cmbSinifEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubeSiniflar.SelectedItems.Count > 0)
            {

                int toplam = chkLbxEgitimGunleri.Items.Count;
                for (int i = 0; i < toplam; i++)
                {
                    chkLbxEgitimGunleri.SetItemChecked(i, false);
                };

                sinif = ((Sinif)lstSubeSiniflar.SelectedItems[0].Tag);

                txtSinifKodu.Text = sinif.SinifKodu;
                dtSinifBaslangicTarihi.Value = sinif.EgitimBaslangic;
                dtSinifBitisTarihi.Value = sinif.EgitimBitis;
                cmbSinifEgitim.Text = db.Egitimler.FirstOrDefault(x => x.EgitimID == sinif.EgitimID).EgitimAdi;
                cmbSinifEgitmen.Text = db.SiniflarEgitmenler.FirstOrDefault(x => x.SinifKodu == sinif.SinifKodu).Egitmen.ToString();
                txtSinifBaslangicSaati.Text = sinif.BaslangicSaati;
                txtSinifBitisSaati.Text = sinif.BitiscSaati;
                nmrEgitimSuresi.Value = sinif.GunlukEgitimSaati;



                if (sinif.Pazartesi == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(0, true);
                }
                if (sinif.Sali == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(1, true);
                }
                if (sinif.Carsamba == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(2, true);
                }
                if (sinif.Persembe == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(3, true);
                }
                if (sinif.Cuma == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(4, true);
                }
                if (sinif.Cumartesi == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(5, true);
                }
                if (sinif.Pazar == true)
                {
                    chkLbxEgitimGunleri.SetItemChecked(6, true);
                }

            }
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            new SinifEgitimSil(sinif.SinifKodu);
            SiniflariListele();
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            string takvimilkgun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)dtSinifBaslangicTarihi.Value.DayOfWeek];

            int yenigunlukegitimsaati = (int)nmrEgitimSuresi.Value; // seçilen yeni günlük egitim süresi
            DateTime yenibaslangıc = dtSinifBaslangicTarihi.Value; //Seçilen eğitimin başlangıç tarihi

            DateTime eskibaslangıc = sinif.EgitimBaslangic;

            int eskigunluksaat = sinif.GunlukEgitimSaati;

            int gecengunsayi = (int)(yenibaslangıc - eskibaslangıc).TotalDays; // negatif dönüyorrrrr  eskibaslangıc

            Egitim egitim = db.Egitimler.FirstOrDefault(x => x.EgitimID == ((Egitim)cmbSinifEgitim.SelectedItem).EgitimID); //Eğitim nesnesi

            int egitimSuresi = egitim.EgitimSuresi; //Toplam verilecek eğitim saati

            List<string> eskigunler = new List<string>();
            if (sinif.Pazartesi == true) eskigunler.Add("Pazartesi");

            if (sinif.Sali == true) eskigunler.Add("Salı");

            if (sinif.Carsamba == true) eskigunler.Add("Çarşamba");

            if (sinif.Persembe == true) eskigunler.Add("Perşembe");

            if (sinif.Cuma == true) eskigunler.Add("Cuma");

            if (sinif.Cumartesi == true) eskigunler.Add("Cumartesi");

            if (sinif.Pazar == true) eskigunler.Add("Pazar");

            int ekleme = 0;
            int islenendersgunu = 0;
            for (int i = 0; i < gecengunsayi; i++)
            {
                ++ekleme;
                eskibaslangıc = eskibaslangıc.AddDays(ekleme);
                string eskibaslangıcgunu = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)eskibaslangıc.DayOfWeek];

                foreach (var item in eskigunler)
                {
                    if (item.Contains(eskibaslangıcgunu))
                    {
                        ++islenendersgunu;
                    }
                }
                eskibaslangıc = eskibaslangıc.AddDays(-ekleme);
            }
            int eskiislenensaattoplam = (islenendersgunu + 1) * (int)eskigunluksaat;

            int kalanegitimsuresi = egitimSuresi - eskiislenensaattoplam;


            //------------------------------------------------------------------------------------------------------------------

            List<string> glessonDays = new List<string>();
            foreach (var item in chkLbxEgitimGunleri.CheckedItems)
            {
                glessonDays.Add(item.ToString());
            }
            int gegitimGunleri = 0;
            for (int i = 0; i < chkLbxEgitimGunleri.CheckedItems.Count; i++)
            {
                gegitimGunleri++;
            }

            int ghaftaEgitimSaat = gegitimGunleri * yenigunlukegitimsaati;

            double gtoplamHafta = kalanegitimsuresi / (gegitimGunleri * yenigunlukegitimsaati);


            if (takvimilkgun == glessonDays.First())
            {
                if (kalanegitimsuresi % ghaftaEgitimSaat == 0)
                {
                    gtoplamHafta = 7 * (gtoplamHafta - 1);
                    int sonGun = 0;
                    switch (glessonDays.Last())
                    {

                        case "Pazartesi":
                            sonGun = 1;
                            break;
                        case "Salı":
                            sonGun = 2;
                            break;
                        case "Çarşamba":
                            sonGun = 3;
                            break;
                        case "Perşembe":
                            sonGun = 4;
                            break;
                        case "Cuma":
                            sonGun = 5;
                            break;
                        case "Cumartesi":
                            sonGun = 6;
                            break;
                        case "Pazar":
                            sonGun = 7;
                            break;
                    }

                    int x = (int)(gtoplamHafta + sonGun);

                    dtSinifBitisTarihi.Value = dtSinifBaslangicTarihi.Value.AddDays(Convert.ToDouble(x - 1));

                    Sinif sinifss = new Sinif();
                    sinifss.SinifKodu = sinif.SinifKodu;
                    sinifss.EgitimBaslangic = dtSinifBaslangicTarihi.Value;
                    sinifss.EgitimBitis = dtSinifBitisTarihi.Value;
                    sinifss.BaslangicSaati = txtSinifBaslangicSaati.Text;
                    sinifss.BitiscSaati = txtSinifBitisSaati.Text;
                    sinifss.GunlukEgitimSaati = (int)nmrEgitimSuresi.Value;

                    List<string> ylessonDays = new List<string>();
                    foreach (var item in chkLbxEgitimGunleri.CheckedItems)
                    {
                        ylessonDays.Add(item.ToString());
                    }
                    foreach (var item in ylessonDays)
                    {
                        if (item == "Pazartesi") sinifss.Pazartesi = true;
                        if (item == "Salı") sinifss.Sali = true;
                        if (item == "Çarşamba") sinifss.Carsamba = true;
                        if (item == "Perşembe") sinifss.Persembe = true;
                        if (item == "Cuma") sinifss.Cuma = true;
                        if (item == "Cumartesi") sinifss.Cumartesi = true;
                        if (item == "Pazar") sinifss.Pazar = true;

                    }
                    new SinifEgitimGuncelle(sinifss);
                    SiniflariListele();
                    MessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
                }
                else
                {
                    if (takvimilkgun == glessonDays.First())
                    {

                        int y = 0;
                        int sonGun = 0;
                        y = (int)(10 * (gtoplamHafta));
                        int artansaat = (int)(kalanegitimsuresi - y);

                        if (yenigunlukegitimsaati > artansaat)
                        {
                            switch (glessonDays.First())
                            {

                                case "Pazartesi":
                                    sonGun = 1;
                                    break;
                                case "Salı":
                                    sonGun = 2;
                                    break;
                                case "Çarşamba":
                                    sonGun = 3;
                                    break;
                                case "Perşembe":
                                    sonGun = 4;
                                    break;
                                case "Cuma":
                                    sonGun = 5;
                                    break;
                                case "Cumartesi":
                                    sonGun = 6;
                                    break;
                                case "Pazar":
                                    sonGun = 7;
                                    break;
                            }

                            int sonuc = (int)((7 * gtoplamHafta) + sonGun);
                            dtSinifBitisTarihi.Value = dtSinifBaslangicTarihi.Value.AddDays(Convert.ToDouble(sonuc - 1));
                            Sinif sinifss = new Sinif();

                            sinifss.EgitimBaslangic = dtSinifBaslangicTarihi.Value;
                            sinifss.EgitimBitis = dtSinifBitisTarihi.Value;
                            sinifss.BaslangicSaati = txtSinifBaslangicSaati.Text;
                            sinifss.BitiscSaati = txtSinifBitisSaati.Text;
                            sinifss.GunlukEgitimSaati = (int)nmrEgitimSuresi.Value;

                            List<string> ylessonDays = new List<string>();
                            foreach (var item in chkLbxEgitimGunleri.CheckedItems)
                            {
                                ylessonDays.Add(item.ToString());
                            }
                            foreach (var item in ylessonDays)
                            {
                                if (item == "Pazartesi") sinifss.Pazartesi = true;
                                if (item == "Salı") sinifss.Sali = true;
                                if (item == "Çarşamba") sinifss.Carsamba = true;
                                if (item == "Perşembe") sinifss.Persembe = true;
                                if (item == "Cuma") sinifss.Cuma = true;
                                if (item == "Cumartesi") sinifss.Cumartesi = true;
                                if (item == "Pazar") sinifss.Pazar = true;

                            }
                            new SinifEgitimGuncelle(sinif);
                            SiniflariListele();
                            MessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN EĞİTİM BAŞLANGIÇ TARİHİNİ " + glessonDays.First() + " OLARAK AYARLAYINIZ");
                    }
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN EĞİTİM BAŞLANGIÇ TARİHİNİ " + glessonDays.First() + " OLARAK AYARLAYINIZ");
            };
        }
    }
}
