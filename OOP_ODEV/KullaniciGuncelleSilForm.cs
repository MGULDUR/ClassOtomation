using DAL;
using DATA;
using DATA.Enums;
using OOP_ODEV.Concretes;
using OOP_ODEV.Concretes.EgitmenC;
using OOP_ODEV.Concretes.Genel;
using OOP_ODEV.Concretes.KoordinatorC;
using OOP_ODEV.Concretes.YoneticiC;
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
    public partial class KullaniciGuncelleSilForm : Form
    {
        Context db;
        public KullaniciGuncelleSilForm()
        {
            db = new Context();
            InitializeComponent();
        }

        private void KullaniciGuncelleSilForm_Load(object sender, EventArgs e)
        {
            cmbKullaniciGorevi.Items.AddRange(Enum.GetNames(typeof(Gorevler)));
            cmbKullaniciSubesi.DataSource = db.Subeler.ToList();
            cmbKullaniciSubesi.DisplayMember = "SubeAdi";
            cmbKullaniciGorevi.SelectedIndex = cmbKullaniciSubesi.SelectedIndex = -1;
        }

        private void btnKullaniciAramaYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (BosAlanKontrol.EmptyAreaControl(grpAramaYap)) MessageBox.Show("Boş alan bırakmayınız");
                else
                {
                    lstKullanicilar.Items.Clear();
                    switch (cmbGoreveGoreAra.Text)
                    {
                        case "Yonetici":
                            try
                            {
                                foreach (Yonetici item in db.Yoneticiler.Where(x => x.IsActive == true && (x.Adi.Contains(txtAdaGoreAra.Text) || x.Soyadi.Contains(txtAdaGoreAra.Text))).ToList())
                                {
                                    ListViewItem lvi = new ListViewItem();
                                    lvi.Text = item.Adi;
                                    lvi.SubItems.Add(item.Soyadi);
                                    lvi.SubItems.Add(item.CepTelefonu);
                                    lvi.SubItems.Add(item.Email);
                                    lvi.SubItems.Add(Enum.GetName(typeof(Gorevler), item.Gorevi));
                                    lvi.SubItems.Add("-");
                                    lvi.Tag = item;
                                    lstKullanicilar.Items.Add(lvi);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                            break;

                        case "Koordinator":
                            try
                            {
                                foreach (Koordinator item in db.Koordinatorler.Where(x => x.IsActive == true && (x.Adi.Contains(txtAdaGoreAra.Text) || x.Soyadi.Contains(txtAdaGoreAra.Text))).ToList())
                                {
                                    ListViewItem lvi = new ListViewItem();
                                    lvi.Text = item.Adi;
                                    lvi.SubItems.Add(item.Soyadi);
                                    lvi.SubItems.Add(item.CepTelefonu);
                                    lvi.SubItems.Add(item.Email);
                                    lvi.SubItems.Add(Enum.GetName(typeof(Gorevler), item.Gorevi));
                                    if (db.Subeler.FirstOrDefault(x => x.SubeID == item.SubeID) != null) lvi.SubItems.Add(db.Subeler.FirstOrDefault(x => x.SubeID == item.SubeID).SubeAdi);
                                    else lvi.SubItems.Add("-");
                                    lvi.Tag = item;
                                    lstKullanicilar.Items.Add(lvi);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            break;

                        case "Egitmen":
                            try
                            {
                                foreach (Egitmen item in db.Egitmenler.Where(x => x.IsActive == true && (x.Adi.Contains(txtAdaGoreAra.Text) || x.Soyadi.Contains(txtAdaGoreAra.Text))).ToList())
                                {
                                    ListViewItem lvi = new ListViewItem();
                                    lvi.Text = item.Adi;
                                    lvi.SubItems.Add(item.Soyadi);
                                    lvi.SubItems.Add(item.CepTelefonu);
                                    lvi.SubItems.Add(item.Email);
                                    lvi.SubItems.Add(Enum.GetName(typeof(Gorevler), item.Gorevi));
                                    if (db.Subeler.FirstOrDefault(x => x.SubeID == item.SubeID) != null) lvi.SubItems.Add(db.Subeler.FirstOrDefault(x => x.SubeID == item.SubeID).SubeAdi);
                                    else lvi.SubItems.Add("-");
                                    lvi.Tag = item;
                                    lstKullanicilar.Items.Add(lvi);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Yonetici seciliYonetici;
        Koordinator seciliKoordinator;
        Egitmen seciliEgitmen;
        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItems.Count > 0)
            {
                cmbKullaniciGorevi.Text = cmbKullaniciSubesi.Text = string.Empty;
                pbxKullaniciResmi.Refresh();
                switch (cmbGoreveGoreAra.Text)
                {
                    case "Yonetici":
                        seciliYonetici = lstKullanicilar.SelectedItems[0].Tag as Yonetici;
                        txtKullaniciAdi.Text = seciliYonetici.Adi;
                        txtKullaniciSoyadi.Text = seciliYonetici.Soyadi;
                        dtKullaniciDTarihi.Value = seciliYonetici.DogumTarihi;
                        txtKullaniciCepTelefonu.Text = seciliYonetici.CepTelefonu;
                        cmbKullaniciGorevi.Text = seciliYonetici.Gorevi.ToString();
                        txtKullaniciMailAdresi.Text = seciliYonetici.Email;
                        txtKullaniciParola.Text = seciliYonetici.Sifre;
                        if (seciliYonetici.Foto != null) pbxKullaniciResmi.Image = Converts.ByteToImage(seciliYonetici.Foto);
                        else pbxKullaniciResmi.Image = null;
                        break;
                    case "Koordinator":
                        seciliKoordinator = lstKullanicilar.SelectedItems[0].Tag as Koordinator;
                        txtKullaniciAdi.Text = seciliKoordinator.Adi;
                        txtKullaniciSoyadi.Text = seciliKoordinator.Soyadi;
                        dtKullaniciDTarihi.Value = seciliKoordinator.DogumTarihi;
                        txtKullaniciCepTelefonu.Text = seciliKoordinator.CepTelefonu;
                        cmbKullaniciGorevi.Text = seciliKoordinator.Gorevi.ToString();
                        cmbKullaniciSubesi.Text = db.Subeler.FirstOrDefault(x => x.SubeID == seciliKoordinator.SubeID) != null ? db.Subeler.FirstOrDefault(x => x.SubeID == seciliKoordinator.SubeID).SubeAdi : string.Empty;
                        txtKullaniciMailAdresi.Text = seciliKoordinator.Email;
                        txtKullaniciParola.Text = seciliKoordinator.Email;
                        if (seciliKoordinator.Foto != null) pbxKullaniciResmi.Image = Converts.ByteToImage(seciliKoordinator.Foto);
                        else pbxKullaniciResmi.Image = null;
                        break;
                    case "Egitmen":
                        seciliEgitmen = lstKullanicilar.SelectedItems[0].Tag as Egitmen;
                        txtKullaniciAdi.Text = seciliEgitmen.Adi;
                        txtKullaniciSoyadi.Text = seciliEgitmen.Soyadi;
                        dtKullaniciDTarihi.Value = seciliEgitmen.DogumTarihi;
                        txtKullaniciCepTelefonu.Text = seciliEgitmen.CepTelefonu;
                        cmbKullaniciGorevi.Text = seciliEgitmen.Gorevi.ToString();
                        cmbKullaniciSubesi.Text = db.Subeler.FirstOrDefault(x => x.SubeID == seciliEgitmen.SubeID) != null ? db.Subeler.FirstOrDefault(x => x.SubeID == seciliEgitmen.SubeID).SubeAdi : string.Empty;
                        txtKullaniciMailAdresi.Text = seciliEgitmen.Email;
                        txtKullaniciParola.Text = seciliEgitmen.Email;
                        if (seciliEgitmen.Foto != null) pbxKullaniciResmi.Image = Converts.ByteToImage(seciliEgitmen.Foto);
                        else pbxKullaniciResmi.Image = null;
                        break;
                }
            }
        }
        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbKullaniciGorevi.Text)
                {
                    case "Yonetici":
                        if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text && x.YoneticiID != seciliYonetici.YoneticiID) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                        else
                        {
                            seciliYonetici.Adi = txtKullaniciAdi.Text;
                            seciliYonetici.Soyadi = txtKullaniciSoyadi.Text;
                            seciliYonetici.DogumTarihi = dtKullaniciDTarihi.Value;
                            seciliYonetici.CepTelefonu = txtKullaniciCepTelefonu.Text;
                            seciliYonetici.Gorevi = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGoreveGoreAra.Text);
                            seciliYonetici.Email = txtKullaniciMailAdresi.Text;
                            seciliYonetici.Sifre = txtKullaniciParola.Text;
                            new YoneticiGuncelle(seciliYonetici, this.pbxKullaniciResmi);
                            MessageBox.Show("İşlem başarılı");
                            lstKullanicilar.Items.Clear();
                            Temizle.Clean(this.Controls);
                        }

                        break;
                    case "Koordinator":

                        if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text && x.KoordinatorID != seciliKoordinator.KoordinatorID) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                        else
                        {

                            seciliKoordinator.Adi = txtKullaniciAdi.Text;
                            seciliKoordinator.Soyadi = txtKullaniciSoyadi.Text;
                            seciliKoordinator.DogumTarihi = dtKullaniciDTarihi.Value;
                            seciliKoordinator.CepTelefonu = txtKullaniciCepTelefonu.Text;
                            seciliKoordinator.Gorevi = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGoreveGoreAra.Text);
                            seciliKoordinator.SubeID = (cmbKullaniciSubesi.SelectedItem as Sube).SubeID;
                            seciliKoordinator.Email = txtKullaniciMailAdresi.Text;
                            seciliKoordinator.Sifre = txtKullaniciParola.Text;
                            new KoordinatorGuncelle(seciliKoordinator, this.pbxKullaniciResmi);
                            MessageBox.Show("İşlem başarılı");
                            lstKullanicilar.Items.Clear();
                            Temizle.Clean(this.Controls);

                        }
                        break;
                    case "Egitmen":
                        if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text && x.EgitmenID != seciliEgitmen.EgitmenID) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                        else
                        {
                            if (seciliEgitmen.SubeID != null) MessageBox.Show("Şubesi olan eğitmeni başka şubeye atayamazsınız");
                            else
                            {
                                seciliEgitmen.Adi = txtKullaniciAdi.Text;
                                seciliEgitmen.Soyadi = txtKullaniciSoyadi.Text;
                                seciliEgitmen.DogumTarihi = dtKullaniciDTarihi.Value;
                                seciliEgitmen.CepTelefonu = txtKullaniciCepTelefonu.Text;
                                seciliEgitmen.Gorevi = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGoreveGoreAra.Text);
                                seciliEgitmen.SubeID = (cmbKullaniciSubesi.SelectedItem as Sube).SubeID;
                                seciliEgitmen.Email = txtKullaniciMailAdresi.Text;
                                seciliEgitmen.Sifre = txtKullaniciParola.Text;
                                new EgitmenGuncelle(seciliEgitmen, this.pbxKullaniciResmi);
                                MessageBox.Show("İşlem başarılı");
                                lstKullanicilar.Items.Clear();
                                Temizle.Clean(this.Controls);
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnKullaniciResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fotoğraf Seç";
            ofd.Filter = "PNG|*.png|JPG|*.jpg";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pbxKullaniciResmi.ImageLocation = ofd.FileName;
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            switch (cmbKullaniciGorevi.Text)
            {
                case "Yonetici":
                    new YoneticiSil(seciliYonetici);
                    MessageBox.Show("İşlem başarılı");
                    lstKullanicilar.Items.Clear();
                    Temizle.Clean(this.Controls);
                    break;
                case "Koordinator":
                    new KoordinatorSil(seciliKoordinator);
                    MessageBox.Show("İşlem başarılı");
                    lstKullanicilar.Items.Clear();
                    Temizle.Clean(this.Controls);
                    break;
                case "Egitmen":
                    new EgitmenSil(seciliEgitmen);
                    MessageBox.Show("İşlem başarılı");
                    lstKullanicilar.Items.Clear();
                    Temizle.Clean(this.Controls);
                    break;
            }
        }

        private void chkKullaniciOtoParola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKullaniciOtoParola.Checked)
            {
                txtKullaniciParola.Text = string.Empty;
                RandomPassword rp = new RandomPassword();
                txtKullaniciParola.Text = rp.Create();
            }
        }
    }
}
