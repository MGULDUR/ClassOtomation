using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Koordinator : Kullanici
    {
        public int KoordinatorID { get; set; }


        //Navigation Prop

        public int? SubeID { get; set; }
        public virtual Sube Sube { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
