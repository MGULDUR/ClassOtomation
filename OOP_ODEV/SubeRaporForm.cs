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
    public partial class SubeRaporForm : Form
    {
        Koordinator gelenKoordinator;
        Context db;
        public SubeRaporForm(Koordinator koordinator)
        {
            db = new Context();
            gelenKoordinator = koordinator;
            InitializeComponent();
        }
        public SubeRaporForm()
        {
            db = new Context();
            InitializeComponent();
        }
        private void SubeRaporForm_Load(object sender, EventArgs e)
        {
            if (gelenKoordinator != null)
            {
                cmbSubeSec.DataSource = db.Subeler.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).ToList();
                cmbSubeSec.DisplayMember = "SubeAdi";
                cmbSubeSec.ValueMember = "SubeID";
                if (cmbSubeSec.Items.Count > 0) cmbSubeSec.SelectedIndex = 0;
                cmbSubeSec.Enabled = false;

                Sube seciliSube = db.Subeler.FirstOrDefault(x => x.SubeID == (int)cmbSubeSec.SelectedValue);

                if (db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblKoordinatorSayisi.Text = db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblKoordinatorSayisi.Text = "0";

                if (db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblEgitmenSayisi.Text = db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblEgitmenSayisi.Text = "0";

                if (db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblsinifSayisi.Text = db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblsinifSayisi.Text = "0";

                int ogrenciSayisi = 0;
                foreach (Sinif sinif in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                {
                    foreach (var ogrenci in db.Ogrenciler.Where(x => x.SinifKodu == sinif.SinifKodu && x.IsActive == true).ToList())
                    {
                        ogrenciSayisi++;
                    }
                }
                if (ogrenciSayisi > 0) lblOgrenciSayisi.Text = ogrenciSayisi.ToString();
                else lblOgrenciSayisi.Text = "0";

                decimal verilenDersSaati = 0;
                int haftalikDersSaati = 0;

                foreach (Sinif item in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                {
                    if (item.Pazartesi == true) haftalikDersSaati += 1;
                    if (item.Sali == true) haftalikDersSaati += 1;
                    if (item.Carsamba == true) haftalikDersSaati += 1;
                    if (item.Persembe == true) haftalikDersSaati += 1;
                    if (item.Cuma == true) haftalikDersSaati += 1;
                    if (item.Cumartesi == true) haftalikDersSaati += 1;
                    if (item.Pazar == true) haftalikDersSaati += 1;

                    var zaman = DateTime.Now - item.EgitimBaslangic; // Günler eklenecek
                    if (haftalikDersSaati != 0) verilenDersSaati += Convert.ToDecimal(zaman.TotalDays) / (item.GunlukEgitimSaati * haftalikDersSaati);
                }

                if (verilenDersSaati > 0 && haftalikDersSaati > 0) lblVerilenDersSaati.Text = Math.Ceiling(verilenDersSaati).ToString();
                else lblVerilenDersSaati.Text = "0";


                if (db.SiniflarEgitmenler.Where(x => x.IsActive == true).ToList() != null)
                {
                    int egitmenSayisi = db.SiniflarEgitmenler.Where(x => x.IsActive == true).Count();
                    if (egitmenSayisi != 0) lblVerilenDersEgitmenOrt.Text = Math.Round((verilenDersSaati / egitmenSayisi), 2).ToString();
                    else lblVerilenDersEgitmenOrt.Text = "0";
                }

                //int egitmenSayisi = db.SiniflarEgitmenler.Where(x => x.IsActive == true).Sum(x => x.EgitmenID);
                //if (egitmenSayisi != 0) lblVerilenDersEgitmenOrt.Text = Math.Round((verilenDersSaati / egitmenSayisi), 2).ToString();
                //else lblVerilenDersEgitmenOrt.Text = "0";
            }
            else
            {
                cmbSubeSec.Text = "";
                cmbSubeSec.DisplayMember = "SubeAdi";
                cmbSubeSec.ValueMember = "SubeID";
                cmbSubeSec.DataSource = db.Subeler.Where(x => x.IsActive == true).ToList();
            }
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);



            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);




            iTextSharp.text.Document rapor = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(rapor, new FileStream("C:SubeRaporForm.pdf", FileMode.Create));
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph(new Phrase("SUBE RAPOR FORMU", fontNormal)));
            rapor.Add(new Paragraph(new Phrase(label3.Text + lblKoordinatorSayisi.Text, fontNormal)));
            rapor.Add(new Paragraph(new Phrase(label4.Text + lblEgitmenSayisi.Text, fontNormal)));
            rapor.Add(new Paragraph(new Phrase(label5.Text + lblOgrenciSayisi.Text, fontNormal)));
            rapor.Add(new Paragraph(new Phrase(label15.Text + lblsinifSayisi.Text, fontNormal)));
            rapor.Add(new Paragraph(new Phrase(verilenDersSaati.Text + lblVerilenDersSaati.Text, fontNormal)));
            rapor.Add(new Paragraph(new Phrase(label11.Text + lblVerilenDersEgitmenOrt.Text, fontNormal)));
            rapor.Close();
            MessageBox.Show("PDF Oluşturuldu");
        }

        private void cmbSubeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gelenKoordinator == null)
            {
                Sube seciliSube = db.Subeler.FirstOrDefault(x => x.SubeID == (int)cmbSubeSec.SelectedValue);

                if (db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblKoordinatorSayisi.Text = db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblKoordinatorSayisi.Text = "0";

                if (db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblEgitmenSayisi.Text = db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblEgitmenSayisi.Text = "0";

                if (db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblsinifSayisi.Text = db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblsinifSayisi.Text = "0";

                int ogrenciSayisi = 0;
                foreach (Sinif sinif in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                {
                    foreach (var ogrenci in db.Ogrenciler.Where(x => x.SinifKodu == sinif.SinifKodu && x.IsActive == true).ToList())
                    {
                        ogrenciSayisi++;
                    }
                }
                if (ogrenciSayisi > 0) lblOgrenciSayisi.Text = ogrenciSayisi.ToString();
                else lblOgrenciSayisi.Text = "0";

                decimal verilenDersSaati = 0;
                int haftalikDersSaati = 0;

                foreach (Sinif item in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                {
                    if (item.Pazartesi == true) haftalikDersSaati += 1;
                    if (item.Sali == true) haftalikDersSaati += 1;
                    if (item.Carsamba == true) haftalikDersSaati += 1;
                    if (item.Persembe == true) haftalikDersSaati += 1;
                    if (item.Cuma == true) haftalikDersSaati += 1;
                    if (item.Cumartesi == true) haftalikDersSaati += 1;
                    if (item.Pazar == true) haftalikDersSaati += 1;

                    var zaman = DateTime.Now - item.EgitimBaslangic; // Günler eklenecek
                    if (haftalikDersSaati != 0) verilenDersSaati += Convert.ToDecimal(zaman.TotalDays) / (item.GunlukEgitimSaati * haftalikDersSaati);
                }

                if (verilenDersSaati > 0) lblVerilenDersSaati.Text = Math.Ceiling(verilenDersSaati).ToString();
                else lblVerilenDersSaati.Text = "0";

                int egitmenSayisi = db.SiniflarEgitmenler.Where(x => x.IsActive == true).Sum(x => x.EgitmenID);
                if (egitmenSayisi != 0) lblVerilenDersEgitmenOrt.Text = Math.Round((verilenDersSaati / egitmenSayisi), 2).ToString();
                else lblVerilenDersEgitmenOrt.Text = "0";
            }



        }
    }
}
