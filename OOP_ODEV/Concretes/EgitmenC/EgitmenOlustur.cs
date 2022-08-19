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

namespace OOP_ODEV.Concretes.EgitmenC
{
    public class EgitmenOlustur
    {
        Context db;
        public EgitmenOlustur(string ad, string soyad, DateTime tarih, string telefon, Gorevler gorev, int subeid, string mail, string parola, PictureBox foto)
        {
            db = new Context();

            Egitmen egitmen = new Egitmen();
            egitmen.Adi = ad;
            egitmen.Soyadi = soyad;
            egitmen.DogumTarihi = tarih;
            egitmen.CepTelefonu = telefon;
            egitmen.Gorevi = gorev;
            egitmen.SubeID = subeid;
            egitmen.Email = mail;
            egitmen.Sifre = parola;
            egitmen.IsActive = true;
            //if (egitmen.Foto == null)
            //{
            //    db.Egitmenler.Add(egitmen);
            //    db.SaveChanges();
            //}
            if (foto.Image != null)
            {
                egitmen.Foto = Converts.FillToByte(foto.ImageLocation);
                db.Egitmenler.Add(egitmen);
                db.SaveChanges();
            }
            else
            {
                db.Egitmenler.Add(egitmen);
                db.SaveChanges();
            }
        }
    }
}
