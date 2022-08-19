using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class SiniflarEgitmenler : Active
    {
        public string SinifKodu { get; set; }
        public Sinif Sinif { get; set; }
        public int EgitmenID { get; set; }
        public Egitmen Egitmen { get; set; }
    }
}
