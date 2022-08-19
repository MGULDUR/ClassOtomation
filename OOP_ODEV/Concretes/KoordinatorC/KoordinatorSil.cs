using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.KoordinatorC
{
    public class KoordinatorSil
    {
        Context db;
        public KoordinatorSil(Koordinator koordinator)
        {
            db = new Context();
            db.Koordinatorler.FirstOrDefault(x => x.KoordinatorID == koordinator.KoordinatorID).IsActive = false;
            db.SaveChanges();
        }
    }
}
