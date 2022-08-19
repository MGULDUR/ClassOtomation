using DAL;
using DATA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class SinifRaporForm : Form
    {
        Koordinator gelenKoordinator;
        Context db;
        public SinifRaporForm(Koordinator koordinator)
        {
            gelenKoordinator = koordinator;
            db = new Context();
            InitializeComponent();
        }
        public SinifRaporForm()
        {
            db = new Context();
            InitializeComponent();
        }

        private void SinifRaporForm_Load(object sender, EventArgs e)
        {
            if (db.Subeler.Where(x => x.IsActive == true).ToList().Count > 0)
            {
                if (gelenKoordinator != null)
                {
                    cmbSinifRaporSubeSec.ValueMember = "SubeID";
                    cmbSinifRaporSubeSec.DisplayMember = "SubeAdi";
                    cmbSinifRaporSubeSec.DataSource = db.Subeler.Where(x => (x.SubeID == gelenKoordinator.SubeID) && (x.IsActive == true)).ToList();
                    cmbSinifRaporSubeSec.Text = "";
                    cmbSinifRaporSinifSec.Enabled = false;
                    cmbSinifRaporSinifSec.Text = "";
                }
                else
                {
                    cmbSinifRaporSubeSec.DataSource = db.Subeler.Where(x => x.IsActive == true).ToList();
                    cmbSinifRaporSubeSec.ValueMember = "SubeID";
                    cmbSinifRaporSubeSec.DisplayMember = "SubeAdi";
                    cmbSinifRaporSubeSec.Text = "";
                    cmbSinifRaporSinifSec.Enabled = false;
                }

            }
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "PDF Kaydet";
            sfd.Filter = "PDF Files (*.pdf) | *.pdf";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document sinifraporForm = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(sinifraporForm, new FileStream(sfd.FileName, FileMode.CreateNew));
                if (sinifraporForm.IsOpen() == false)
                {
                    sinifraporForm.Open();
                }
                sinifraporForm.Add(new Paragraph("SINIF RAPOR FORMU", fontNormal));
                sinifraporForm.Add(new Paragraph(label3.Text + lblYapilanDersSaati.Text, fontNormal));
                sinifraporForm.Add(new Paragraph(label8.Text + lblOgrenciSayisi.Text, fontNormal));
                sinifraporForm.Add(new Paragraph(label4.Text + lblKalanDersSaati.Text, fontNormal));
                sinifraporForm.Add(new Paragraph(label7.Text + lblEgitmen.Text, fontNormal));
                sinifraporForm.Add(new Paragraph(" ", fontNormal));
                sinifraporForm.Add(new Paragraph("Sıra No" + "Öğrenci Adı Soyadı" + "Katıldığı Ders Saati" + "Devam Durumu(%)", fontNormal));

                for (int i = 0; i < lvSinifListesi.Items.Count; i++)
                {
                    sinifraporForm.Add(new Paragraph(lvSinifListesi.Items[i].SubItems[0].Text + lvSinifListesi.Items[i].SubItems[1].Text, fontNormal));
                }

                sinifraporForm.Close();
                MessageBox.Show("PDF Oluşturuldu");
            }
        }

        private void cmbSinifRaporSubeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSinifRaporSinifSec.Enabled = true;
                cmbSinifRaporSinifSec.DataSource = db.Siniflar.Where(x => x.SubeID == (int)cmbSinifRaporSubeSec.SelectedValue && x.IsActive == true).ToList();
                cmbSinifRaporSinifSec.Text = string.Empty;
                cmbSinifRaporSinifSec.DisplayMember = "SinifAdi";
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Lütfen şube seçin");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (cmbSinifRaporSinifSec.Text == string.Empty) MessageBox.Show("Lütfen sınıf seçimi yapın");
            else
            {
                Sinif seciliSinif = db.Siniflar.FirstOrDefault(x => x.SinifKodu == cmbSinifRaporSinifSec.Text && x.IsActive == true);
                int seciliSinifHaftalikDersGunu = 0;
                if (seciliSinif.Pazartesi == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Sali == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Carsamba == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Persembe == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Cuma == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Cumartesi == true) seciliSinifHaftalikDersGunu += 1;
                if (seciliSinif.Pazar == true) seciliSinifHaftalikDersGunu += 1;


                if (seciliSinif.EgitimBaslangic != null && seciliSinifHaftalikDersGunu != 0) lblYapilanDersSaati.Text = (Math.Ceiling((DateTime.Now - seciliSinif.EgitimBaslangic).TotalDays) * 24 / (seciliSinifHaftalikDersGunu * seciliSinif.GunlukEgitimSaati)).ToString();
                else lblYapilanDersSaati.Text = "0";
                if (seciliSinifHaftalikDersGunu != 0) lblKalanDersSaati.Text = Math.Ceiling((seciliSinif.EgitimBitis - DateTime.Now).TotalDays) < 0 ? "0" : Math.Ceiling((seciliSinif.EgitimBitis - DateTime.Now).TotalDays).ToString();
                else lblKalanDersSaati.Text = "0";
                lblOgrenciSayisi.Text = db.Ogrenciler.Where(x => x.SinifKodu == seciliSinif.SinifKodu && x.IsActive == true).ToList().Count.ToString();
                string egitmenText = "";
                foreach (var item in db.SiniflarEgitmenler.Where(x => x.SinifKodu == seciliSinif.SinifKodu).ToList())
                {
                    egitmenText += db.Egitmenler.FirstOrDefault(x => x.EgitmenID == item.EgitmenID) + "\n";
                }

                lblEgitmen.Text = egitmenText;


                lvSinifListesi.Items.Clear();
                foreach (var item in db.Ogrenciler.Where(x => x.SinifKodu == cmbSinifRaporSinifSec.Text && x.IsActive == true).ToList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.OgrenciID.ToString();
                    lvi.SubItems.Add(item.ToString());

                    int katildigiDersSayisi = 0;
                    int dersToplami = 0;
                    foreach (var yoklama in db.Yoklamalar.Where(x => x.OgrenciID == item.OgrenciID).ToList())
                    {
                        if (yoklama.Ders1 == true)
                        {
                            katildigiDersSayisi++;
                            dersToplami++;
                        }
                        else dersToplami++;

                        if (yoklama.Ders2 == true)
                        {
                            katildigiDersSayisi++;
                            dersToplami++;
                        }
                        else dersToplami++;

                        if (yoklama.Ders3 == true)
                        {
                            katildigiDersSayisi++;
                            dersToplami++;
                        }
                        else dersToplami++;

                        if (yoklama.Ders4 == true)
                        {
                            katildigiDersSayisi++;
                            dersToplami++;
                        }
                        else dersToplami++;

                        if (yoklama.Ders5 == true)
                        {
                            katildigiDersSayisi++;
                            dersToplami++;
                        }
                        else dersToplami++;
                    }
                    lvi.SubItems.Add(katildigiDersSayisi.ToString());
                    if (dersToplami != 0) lvi.SubItems.Add("%" + (100 * katildigiDersSayisi / dersToplami));
                    else lvi.SubItems.Add("-");

                    lvSinifListesi.Items.Add(lvi);
                }
            }

        }
    }
}
