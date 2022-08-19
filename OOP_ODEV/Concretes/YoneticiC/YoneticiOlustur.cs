using DAL;
using DATA;
using DATA.Enums;
using OOP_ODEV.Concretes.Genel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.YoneticiC
{
    public class YoneticiOlustur
    {
        Context db;
        public YoneticiOlustur(string ad, string soyad, DateTime tarih, string telefon, Gorevler gorev, string mail, string parola, PictureBox foto)
        {
            db = new Context();

            Yonetici yonetici = new Yonetici();
            yonetici.Adi = ad;
            yonetici.Soyadi = soyad;
            yonetici.DogumTarihi = tarih;
            yonetici.CepTelefonu = telefon;
            yonetici.Gorevi = gorev;
            yonetici.Email = mail;
            yonetici.Sifre = parola;
            yonetici.IsActive = true;

            if (yonetici.Foto == null)

            {
                db.Yoneticiler.Add(yonetici);
                db.SaveChanges();

            }



            else if (foto.Image != null)
            {
                yonetici.Foto = Converts.FillToByte(foto.ImageLocation);

                db.Yoneticiler.Add(yonetici);

                db.SaveChanges();

            }

        }
    }
}

