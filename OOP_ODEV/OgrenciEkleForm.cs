using DAL;
using DATA;
using OOP_ODEV.Concretes.Genel;
using OOP_ODEV.Concretes.OgrenciC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{

    public partial class OgrenciEkleForm : Form
    {
        Context db;
        Koordinator koordinator;
        public OgrenciEkleForm(Koordinator koordinator1)
        {
            db = new Context();
            koordinator = koordinator1;
            InitializeComponent();
        }
        private void OgrenciEkleForm_Load(object sender, EventArgs e)
        {
            lblOgrenciSubeAdi.Text = koordinator.Sube.SubeAdi;
            List<Sinif> sinif = db.Siniflar.Where(x => x.SubeID == koordinator.SubeID).ToList();
            foreach (var item in sinif)
            {
                cmbOgrenciSinifi.Items.Add(item.ToString());
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BosAlanKontrol.EmptyAreaControl(grpOgrenciBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayınız");
                else
                {
                    if ((db.Yoneticiler.FirstOrDefault(x => x.Email == txtOgrenciMailAdresi.Text) != null) || (db.Koordinatorler.FirstOrDefault(x => x.Email == txtOgrenciMailAdresi.Text) != null) || (db.Egitmenler.FirstOrDefault(x => x.Email == txtOgrenciMailAdresi.Text) != null) || (db.Ogrenciler.FirstOrDefault(x => x.Email == txtOgrenciMailAdresi.Text) != null)) MessageBox.Show("Mail adresi daha önceden alınmış");
                    else
                    {
                        new OgrenciEkle(txtOgrenciAdi.Text,
                                     txtOgrenciSoyadi.Text,
                                txtOgrenciCepTelefonu.Text,
                                 txtOgrenciMailAdresi.Text,
                                    dtOgrenciDTarihi.Value,
                                     cmbOgrenciSinifi.Text,
                                     this.pbxOgrenciResmi);
                        MessageBox.Show("İşlem başarılı");
                        try
                        {
                            Email.Sender(txtOgrenciAdi.Text, txtOgrenciSoyadi.Text, txtOgrenciMailAdresi.Text);
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

                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Lütfen seçim yapın");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOgrenciResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fotoğraf Seç";
            ofd.Filter = "PNG|*.png|JPG|*.jpg";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pbxOgrenciResmi.ImageLocation = ofd.FileName;
            }
        }
    }
}
