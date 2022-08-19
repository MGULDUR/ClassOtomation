using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.SubeC
{
    public class SubeSil
    {
        Context db;
        public SubeSil(int id)
        {
            db = new Context();
            Sube sube = db.Subeler.Where(x => x.SubeID == id).FirstOrDefault();
            sube.IsActive = false;            
            db.SaveChanges();
            
        }
    }
}
