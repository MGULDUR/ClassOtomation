using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.SınıfEgitimC
{
    public class SinifEgitimEkle
    {
        Context db;
        public SinifEgitimEkle(string sinifKodu, DateTime baslangicTarih, DateTime bitisTarih, int gunlukEgitimSaati, int subeId, int egitimId, string baslangicSaat, string bitisSaat, int egitmenId, List<string> list)
        {
            db = new Context();
            Sinif sinif = new Sinif();
            sinif.SinifKodu = sinifKodu;
            sinif.EgitimBaslangic = baslangicTarih;
            sinif.EgitimBitis = bitisTarih;
            sinif.GunlukEgitimSaati = gunlukEgitimSaati;
            sinif.SubeID = subeId;
            sinif.EgitimID = egitimId;
            sinif.BaslangicSaati = baslangicSaat;
            sinif.BitiscSaati = bitisSaat;
            sinif.IsActive = true;

            foreach (var item in list)
            {
                if (item == "Pazartesi") sinif.Pazartesi = true;
                if (item == "Salı") sinif.Sali = true;
                if (item == "Çarşamba") sinif.Carsamba = true;
                if (item == "Perşembe") sinif.Persembe = true;
                if (item == "Cuma") sinif.Cuma = true;
                if (item == "Cumartesi") sinif.Cumartesi = true;
                if (item == "Pazar") sinif.Pazar = true;

            }
            db.Siniflar.Add(sinif);

            db.SiniflarEgitmenler.Add(new SiniflarEgitmenler() { SinifKodu = sinifKodu, EgitmenID = egitmenId, IsActive = true });
            db.SaveChanges();
        }
    }
}





