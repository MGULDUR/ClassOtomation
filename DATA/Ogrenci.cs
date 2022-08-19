using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Ogrenci : BaseEntity
    {
        public int OgrenciID { get; set; }


        //Navigation Prop

        public virtual Sinif Sinif { get; set; }

        public string SinifKodu { get; set; }

        public virtual List<Yoklama> Yoklamalar { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
