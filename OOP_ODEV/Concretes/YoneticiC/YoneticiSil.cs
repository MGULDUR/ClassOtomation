using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.YoneticiC
{
    public class YoneticiSil
    {
        Context db;

        public YoneticiSil(Yonetici yonetici)
        {
            db.Yoneticiler.FirstOrDefault(x => x.YoneticiID == yonetici.YoneticiID).IsActive = false;
            db.SaveChanges();
        }
    }
}
