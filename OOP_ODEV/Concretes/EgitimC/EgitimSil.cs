using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.EgitimC
{
    public class EgitimSil
    {
        Context db;
        public EgitimSil(int id)
        {
            db = new Context();
            Egitim egitim = db.Egitimler.Where(x => x.EgitimID == id).FirstOrDefault();
            egitim.IsActive = false;
            db.SaveChanges();
        }   
    }
}
