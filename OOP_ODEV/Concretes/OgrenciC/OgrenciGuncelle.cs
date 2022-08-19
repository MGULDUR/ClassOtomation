using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.OgrenciC
{
    public class OgrenciGuncelle
    {
        Context db;
        public OgrenciGuncelle(Ogrenci ogrenci)
        {
            db = new Context();
            Ogrenci oldogrenci1 = db.Ogrenciler.Find(ogrenci.OgrenciID);

            oldogrenci1.Adi = ogrenci.Adi;
            oldogrenci1.Soyadi = ogrenci.Soyadi;
            oldogrenci1.SinifKodu = ogrenci.SinifKodu;
            oldogrenci1.CepTelefonu = ogrenci.CepTelefonu;
            oldogrenci1.DogumTarihi = ogrenci.DogumTarihi;
            oldogrenci1.IsActive = true;
            db.SaveChanges();

        }
    }
}
