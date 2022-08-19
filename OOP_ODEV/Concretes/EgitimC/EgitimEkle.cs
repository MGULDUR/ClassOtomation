using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.EgitimC
{
    public class EgitimEkle
    {
        Context db;
        
        public EgitimEkle(string EgitimAdi,string EgitimAciklamasi,int egitimsuresi)
        {
            db = new Context();

            Egitim egitim = new Egitim();
            egitim.EgitimAdi = EgitimAdi;
            egitim.EgitimAciklamasi = EgitimAciklamasi;
            egitim.EgitimSuresi = egitimsuresi;
            egitim.IsActive = true;

            db.Egitimler.Add(egitim);
            db.SaveChanges();
            //List<Egitim> egitim = db.Egitimler.ToList();
            //egitim.
        }
    }
}
