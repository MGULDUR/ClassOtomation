using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.SınıfEgitimC
{
    public class SinifEgitimSil
    {
        Context db;
        public SinifEgitimSil(string kod)
        {
            db = new Context();
            Sinif sinif = db.Siniflar.Where(x => x.SinifKodu == kod).FirstOrDefault();
            sinif.IsActive = false;
            db.SaveChanges();
        }
    }
}
