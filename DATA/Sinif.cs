using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Sinif : Active
    {
        public Sinif()
        {
           
            SinifEgitmenler = new List<SiniflarEgitmenler>();
        }
        public string SinifKodu { get; set; }
        public DateTime EgitimBaslangic { get; set; }
        public DateTime EgitimBitis { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitiscSaati { get; set; }
        public int GunlukEgitimSaati { get; set; }
        public bool? Pazartesi { get; set; }
        public bool? Sali { get; set; }
        public bool? Carsamba { get; set; }
        public bool? Persembe { get; set; }
        public bool? Cuma { get; set; }
        public bool? Cumartesi { get; set; }
        public bool? Pazar { get; set; }
        

        //Navigation Prop
        public virtual List<SiniflarEgitmenler> SinifEgitmenler { get; set; }       
        public virtual List<Ogrenci> Ogrenciler { get; set; }
        public int SubeID { get; set; }
        public virtual Sube Sube { get; set; }
        public int EgitimID { get; set; }
        public virtual Egitim Egitim { get; set; }

        public override string ToString()
        {
            return SinifKodu;
        }
    }
}
