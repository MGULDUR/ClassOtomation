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

namespace OOP_ODEV.Concretes.KoordinatorC
{
    public class KoordinatorOlustur
    {
        Context db;
        public KoordinatorOlustur(string ad, string soyad, DateTime tarih, string telefon, Gorevler gorev, Sube sube, string mail, string parola, PictureBox foto)
        {
            db = new Context();

            Koordinator koordinator = new Koordinator();
            koordinator.Adi = ad;
            koordinator.Soyadi = soyad;
            koordinator.DogumTarihi = tarih;
            koordinator.CepTelefonu = telefon;
            koordinator.Gorevi = gorev;
            koordinator.Sube = sube;
            koordinator.Email = mail;
            koordinator.Sifre = parola;
            koordinator.IsActive = true;
            //if (koordinator.Foto == null)
            //{
            //    db.Koordinatorler.Add(koordinator);
            //    db.SaveChanges();
            //}
            if (foto.Image != null)
            {
                koordinator.Foto = Converts.FillToByte(foto.ImageLocation);
                db.Koordinatorler.Add(koordinator);
                db.SaveChanges();
            }
            else
            {
                db.Koordinatorler.Add(koordinator);
                db.SaveChanges();
            }
        }
    }
}
