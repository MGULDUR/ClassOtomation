using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Yoklama
    {
        public int YoklamaID { get; set; }
        public bool? Ders1 { get; set; }
        public bool? Ders2 { get; set; }
        public bool? Ders3 { get; set; }
        public bool? Ders4 { get; set; }
        public bool? Ders5 { get; set; }
        public DateTime YoklamaTarih { get; set; }

        //Navigation Property
        public int OgrenciID { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
