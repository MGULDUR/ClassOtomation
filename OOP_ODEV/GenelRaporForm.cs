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
    public partial class GenelRaporForm : Form
    {
        Context db;
        public GenelRaporForm()
        {
            db = new Context();
            InitializeComponent();
        }

        private void GenelRaporForm_Load(object sender, EventArgs e)
        {
            lblYoneticiSayisi.Text = db.Yoneticiler.Where(x => x.IsActive == true).Count().ToString();
            lblSubeSayisi.Text = db.Subeler.Where(x => x.IsActive == true).Count().ToString();
            lblKoordinatorSayisi.Text = db.Koordinatorler.Where(x => x.IsActive == true).Count().ToString();
            lblEgitmenSayisi.Text = db.Egitimler.Where(x => x.IsActive == true).Count().ToString();
            lblOgrenciSayisi.Text = db.Ogrenciler.Where(x => x.IsActive == true).Count().ToString();
            lblEgitimSayisi.Text = db.Egitimler.Where(x => x.IsActive == true).Count().ToString();

            decimal verilenDersSaati = 0;
            int haftalikDersSaati = 0;

            foreach (Sinif item in db.Siniflar.Where(x => x.IsActive == true).ToList())
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
            if (db.Subeler.Where(x => x.IsActive == true).Count() > 0 || verilenDersSaati > 0) lblVerilenDersSubeOrt.Text = Math.Round(verilenDersSaati / db.Subeler.Where(x => x.IsActive == true).Count(), 2).ToString();
            else lblVerilenDersSubeOrt.Text = "0";
            if (db.Egitmenler.Where(x => x.IsActive == true).Count() > 0 || verilenDersSaati > 0) lblVerilenDersEgitmenOrt.Text = Math.Round(verilenDersSaati / db.Egitmenler.Where(x => x.IsActive == true).Count(), 2).ToString();
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);



            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Document genelrapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(genelrapor, new FileStream("C:GenelRaporForm.pdf", FileMode.Create));
            if (genelrapor.IsOpen() == false)
            {
                genelrapor.Open();
            }
            genelrapor.Add(new Paragraph("GENEL RAPOR FORMU", fontNormal));
            genelrapor.Add(new Paragraph(label1.Text + lblYoneticiSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label4.Text + lblEgitmenSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label5.Text + lblOgrenciSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label15.Text + lblEgitimSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label11.Text + lblVerilenDersEgitmenOrt.Text, fontNormal));
            genelrapor.Add(new Paragraph(label2.Text + lblSubeSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label3.Text + lblKoordinatorSayisi.Text, fontNormal));
            genelrapor.Add(new Paragraph(label14.Text + lblVerilenDersSaati.Text, fontNormal));
            genelrapor.Add(new Paragraph(label13.Text + lblVerilenDersSubeOrt.Text, fontNormal));
            genelrapor.Close();
            MessageBox.Show("PDF Oluşturuldu");
        }
    }
}
