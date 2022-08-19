using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.EgitimC
{
    public class EgitimGuncelle
    {
        Context db;
        public EgitimGuncelle(Egitim egitim)
        {
            db = new Context();
            Egitim oldegitim = db.Egitimler.Find(egitim.EgitimID);
            oldegitim.EgitimAdi = egitim.EgitimAdi;
            oldegitim.EgitimAciklamasi = egitim.EgitimAciklamasi;
            oldegitim.EgitimSuresi = egitim.EgitimSuresi;                        
            db.SaveChanges();
        }
    }
}
