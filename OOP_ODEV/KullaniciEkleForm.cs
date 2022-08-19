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
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class KullaniciEkleForm : Form
    {
        Context db;
        Koordinator koordinator;
        public KullaniciEkleForm(Koordinator koordinator1)
        {
            koordinator = koordinator1;
            db = new Context();
            InitializeComponent();
        }
        public KullaniciEkleForm()
        {
            db = new Context();
            InitializeComponent();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {

            cmbKullaniciSubesi.DataSource = db.Subeler.ToList();
            cmbKullaniciSubesi.DisplayMember = "SubeAdi";
            cmbKullaniciSubesi.ValueMember = "SubeID";


            if (koordinator == null) cmbKullaniciGorevi.Items.AddRange(Enum.GetNames(typeof(Gorevler)));
            else cmbKullaniciGorevi.Items.Add(Gorevler.Egitmen);
            cmbKullaniciSubesi.SelectedIndex = cmbKullaniciGorevi.SelectedIndex = -1;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BosAlanKontrol.EmptyAreaControl(grpKullaniciBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayınız");
                else
                {
                    switch (cmbKullaniciGorevi.Text)
                    {
                        case "Yonetici":
                            if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Ogrenciler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                            else
                            {

                                new YoneticiOlustur(txtKullaniciAdi.Text,
                                    txtKullaniciSoyadi.Text,
                                    dtKullaniciDTarihi.Value,
                                    txtKullaniciCepTelefonu.Text,
                                    (Gorevler)Enum.Parse(typeof(Gorevler), cmbKullaniciGorevi.Text),
                                    txtKullaniciMailAdresi.Text,
                                    txtKullaniciParola.Text,
                                    this.pbxKullaniciResmi);
                                MessageBox.Show("İşlem başarılı");
                                try
                                {
                                    Email.Sender(txtKullaniciAdi.Text, txtKullaniciSoyadi.Text, txtKullaniciMailAdresi.Text, txtKullaniciParola.Text);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    Temizle.Clean(this.Controls);
                                }
                            }
                            break;

                        case "Koordinator":
                            if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Ogrenciler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                            else
                            {
                                new KoordinatorOlustur(txtKullaniciAdi.Text,
                                    txtKullaniciSoyadi.Text,
                                    dtKullaniciDTarihi.Value,
                                    txtKullaniciCepTelefonu.Text,
                                    (Gorevler)Enum.Parse(typeof(Gorevler), cmbKullaniciGorevi.Text),
                                    db.Subeler.FirstOrDefault(x => x.SubeAdi == cmbKullaniciSubesi.Text),
                                    txtKullaniciMailAdresi.Text,
                                    txtKullaniciParola.Text, this.pbxKullaniciResmi);
                                MessageBox.Show("İşlem başarılı");
                                try
                                {
                                    Email.Sender(txtKullaniciAdi.Text, txtKullaniciSoyadi.Text, txtKullaniciMailAdresi.Text, txtKullaniciParola.Text);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    Temizle.Clean(this.Controls);
                                }
                            }
                            break;

                        case "Egitmen":
                            if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null) || (db.Ogrenciler.FirstOrDefault(x => x.Email == txtKullaniciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                            else
                            {
                                new EgitmenOlustur(txtKullaniciAdi.Text,
                                    txtKullaniciSoyadi.Text,
                                    dtKullaniciDTarihi.Value,
                                    txtKullaniciCepTelefonu.Text,
                                    (Gorevler)Enum.Parse(typeof(Gorevler), cmbKullaniciGorevi.Text),
                                    (int)cmbKullaniciSubesi.SelectedValue,
                                    txtKullaniciMailAdresi.Text,
                                    txtKullaniciParola.Text, this.pbxKullaniciResmi);
                                MessageBox.Show("İşlem başarılı");
                                try
                                {
                                    Email.Sender(txtKullaniciAdi.Text, txtKullaniciSoyadi.Text, txtKullaniciMailAdresi.Text, txtKullaniciParola.Text);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    Temizle.Clean(this.Controls);
                                }
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

        private void chkKullaniciOtoParola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKullaniciOtoParola.Checked)
            {
                txtKullaniciParola.Text = string.Empty;
                RandomPassword rp = new RandomPassword();
                txtKullaniciParola.Text = rp.Create();
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

        private void cmbKullaniciGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbKullaniciGorevi.Text == "Koordinator") || cmbKullaniciGorevi.Text == "Yonetici")
            {
                cmbKullaniciSubesi.SelectedIndex = -1;
                cmbKullaniciSubesi.Enabled = false;
            }
            else cmbKullaniciSubesi.Enabled = true;

        }
    }
}
