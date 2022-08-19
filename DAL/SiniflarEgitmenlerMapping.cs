using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SiniflarEgitmenlerMapping : EntityTypeConfiguration<SiniflarEgitmenler>
    {
        public SiniflarEgitmenlerMapping()
        {
            HasKey(x => new { x.SinifKodu, x.EgitmenID });
        }
    }
}
