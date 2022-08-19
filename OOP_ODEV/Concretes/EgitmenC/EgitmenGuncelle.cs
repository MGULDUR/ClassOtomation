using DAL;
using DATA;
using OOP_ODEV.Concretes.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.EgitmenC
{
    public class EgitmenGuncelle
    {
        Context db;
        public EgitmenGuncelle(Egitmen egitmen, PictureBox foto)
        {
            Egitmen oldEgitmen = db.Egitmenler.FirstOrDefault(x => x.EgitmenID == egitmen.EgitmenID);

            oldEgitmen.Adi = egitmen.Adi;
            oldEgitmen.Soyadi = egitmen.Soyadi;
            oldEgitmen.DogumTarihi = egitmen.DogumTarihi;
            oldEgitmen.CepTelefonu = egitmen.CepTelefonu;
            oldEgitmen.Gorevi = egitmen.Gorevi;
            oldEgitmen.SubeID = egitmen.SubeID;
            oldEgitmen.Email = egitmen.Email;
            oldEgitmen.Sifre = egitmen.Sifre;
            if (foto.Image != null) oldEgitmen.Foto = Converts.FillToByte(foto.ImageLocation);
            db.SaveChanges();
        }
    }
}
