using DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Kullanici : BaseEntity
    {
        public Gorevler Gorevi { get; set; }
        public string Sifre { get; set; } 
    }
}
