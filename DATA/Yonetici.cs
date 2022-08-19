using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Yonetici : Kullanici
    {
        public int YoneticiID { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
