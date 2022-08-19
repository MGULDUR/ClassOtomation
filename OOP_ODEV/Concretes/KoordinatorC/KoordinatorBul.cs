using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.KoordinatorC
{
    public class KoordinatorBul
    {
        Context db;
        public KoordinatorBul()
        {
            db = new Context();
        }

        public Koordinator FindIt(int id)
        {
            return db.Koordinatorler.FirstOrDefault(x => x.SubeID == id);
        }
    }
}
