using DAL;
using DATA;
using OOP_ODEV.Concretes.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.OgrenciC
{
    public class OgrenciEkle
    {
        Context db;
        public OgrenciEkle(string ad, string soyad, string telefon, string mail, DateTime dogumtarihi, string sinifadi, PictureBox foto)
        {
            db = new Context();
            List<Ogrenci> ogrenci1 = db.Ogrenciler.Where(x => x.SinifKodu == sinifadi && x.IsActive == true).ToList();
            if (ogrenci1.Count() < 15)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Adi = ad;
                ogrenci.Soyadi = soyad;
                ogrenci.CepTelefonu = telefon;
                ogrenci.Email = mail;
                ogrenci.DogumTarihi = dogumtarihi;
                ogrenci.SinifKodu = sinifadi;
                ogrenci.IsActive = true;
                if (foto != null)
                {
                    ogrenci.Foto = Converts.FillToByte(foto.ImageLocation);
                    db.Ogrenciler.Add(ogrenci);
                    db.SaveChanges();
                }
                else
                {
                    db.Ogrenciler.Add(ogrenci);
                    db.SaveChanges();
                }


            }
            else
            {
                MessageBox.Show("Bir sınıf 15 kişiden fazla olamaz");
            }


        }
    }
}
