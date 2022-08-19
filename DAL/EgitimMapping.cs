using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EgitimMapping : EntityTypeConfiguration<Egitim>
    {
        public EgitimMapping()
        {
            HasKey(x => x.EgitimID);
            Property(x => x.EgitimAdi).IsRequired();
            Property(x => x.EgitimAciklamasi).IsRequired();
            Property(x => x.EgitimSuresi).IsRequired();
        }
    }
}
