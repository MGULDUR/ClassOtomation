using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Egitmen : Kullanici
    {
        public Egitmen()
        {
            EgitmenSiniflar = new List<SiniflarEgitmenler>();
        }

        public int EgitmenID { get; set; }

        //Navigation Prop

        public virtual List<SiniflarEgitmenler> EgitmenSiniflar { get; set; }
        public int SubeID { get; set; }
        public virtual Sube Sube { get; set; }
        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
