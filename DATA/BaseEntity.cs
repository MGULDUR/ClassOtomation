using DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BaseEntity : Active
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string CepTelefonu { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public byte[] Foto { get; set; }
    }
}
