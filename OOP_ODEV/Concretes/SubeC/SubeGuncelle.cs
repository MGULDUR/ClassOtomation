using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.SubeC
{
    public class SubeGuncelle
    {
        Context db;
        public SubeGuncelle(Sube sube, int id)
        {
            db = new Context();

            Sube oldSube = db.Subeler.FirstOrDefault(x => x.SubeID == sube.SubeID);
            oldSube.SubeAdi = sube.SubeAdi;
            oldSube.SubeAdresi = sube.SubeAdresi;
            oldSube.SubeMail = sube.SubeMail;
            oldSube.SubeTelefon = sube.SubeTelefon;
            oldSube.IsActive = sube.IsActive;
            //db.Koordinatorler.FirstOrDefault(x => x.SubeID == oldSube.SubeID).SubeID = id;

            db.SaveChanges();
            
            
        }
    }
}
