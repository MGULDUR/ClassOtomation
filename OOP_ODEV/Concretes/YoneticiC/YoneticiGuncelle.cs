using DAL;
using DATA;
using OOP_ODEV.Concretes.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.YoneticiC
{
    class YoneticiGuncelle
    {
        Context db;
        public YoneticiGuncelle(Yonetici yonetici, PictureBox foto)
        {
            db = new Context();

            Yonetici oldYonetici = db.Yoneticiler.FirstOrDefault(x => x.YoneticiID == yonetici.YoneticiID);
            oldYonetici.Adi = yonetici.Adi;
            oldYonetici.Soyadi = yonetici.Soyadi;
            oldYonetici.DogumTarihi = yonetici.DogumTarihi;
            oldYonetici.CepTelefonu = yonetici.CepTelefonu;
            oldYonetici.Gorevi = yonetici.Gorevi;
            oldYonetici.Email = yonetici.Email;
            oldYonetici.Sifre = yonetici.Sifre;
            if (foto.Image != null) oldYonetici.Foto = Converts.FillToByte(foto.ImageLocation);
            db.SaveChanges();
        }

    }
}
