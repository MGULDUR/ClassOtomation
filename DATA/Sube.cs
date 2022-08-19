using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Sube : Active
    {
        public int SubeID { get; set; }
        public string SubeAdi { get; set; }
        public string SubeMail { get; set; }
        public string SubeTelefon { get; set; }
        public string SubeAdresi { get; set; }



        //Navigation Propety 
        public virtual List<Sinif> Siniflar { get; set; }
        public virtual List<Koordinator> Koordinatorler { get; set; }
        public virtual List<Egitmen> Egitmenler { get; set; }

        //public override string ToString()
        //{
        //    return SubeAdi;
        //}
    }
}
