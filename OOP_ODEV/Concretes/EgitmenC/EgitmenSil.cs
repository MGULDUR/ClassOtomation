using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.EgitmenC
{
    public class EgitmenSil
    {
        Context db;
        public EgitmenSil(Egitmen egitmen)
        {
            db.Egitmenler.FirstOrDefault(x => x.EgitmenID == egitmen.EgitmenID).IsActive = false;
            db.SaveChanges();
        }
    }
}
