using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.SınıfEgitimC
{
    public class SinifEgitimGuncelle
    {
        Context db;
        public SinifEgitimGuncelle(Sinif sinif)
        {
            db = new Context();

            Sinif oldsinifi = db.Siniflar.FirstOrDefault(x => x.SinifKodu == sinif.SinifKodu);
            oldsinifi.EgitimBaslangic = sinif.EgitimBaslangic;
            oldsinifi.EgitimBitis = sinif.EgitimBitis;
            oldsinifi.BaslangicSaati = sinif.BaslangicSaati;
            oldsinifi.BitiscSaati = sinif.BitiscSaati;
            oldsinifi.GunlukEgitimSaati = sinif.GunlukEgitimSaati;
            oldsinifi.Pazartesi = sinif.Pazartesi;
            oldsinifi.Sali = sinif.Sali;
            oldsinifi.Carsamba = sinif.Carsamba;
            oldsinifi.Persembe = sinif.Persembe;
            oldsinifi.Cuma = sinif.Cuma;
            oldsinifi.Cumartesi = sinif.Cumartesi;
            oldsinifi.Pazar = sinif.Pazar;
            db.SaveChanges();
        }
    }
}
