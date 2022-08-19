using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.OgrenciC
{
    public class OgrenciSil
    {
        Context db;
        public OgrenciSil(int id)
        {
            db = new Context();

            Ogrenci ogreci = db.Ogrenciler.FirstOrDefault(x => x.OgrenciID == id);
            ogreci.IsActive = false;
            db.SaveChanges();
        }
    }
}
