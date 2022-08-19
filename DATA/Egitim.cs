using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Egitim : Active
    {
        public Egitim()
        {
            
        }

        public int EgitimID { get; set; }
        public string EgitimAdi { get; set; }
        public string EgitimAciklamasi { get; set; }
        public int EgitimSuresi { get; set; }

        public override string ToString()
        {
            return EgitimAdi;
        }


        //Navigation Prop

        public List<Sinif> Siniflar { get; set; }






    }
}
