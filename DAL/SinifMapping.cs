using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinifMapping : EntityTypeConfiguration<Sinif>
    {
        public SinifMapping()
        {
            
            HasKey(x => x.SinifKodu);

            Property(x => x.EgitimBaslangic).IsRequired();

            Property(x => x.EgitimBitis).IsRequired();

            HasRequired(x => x.Sube).WithMany(x => x.Siniflar).HasForeignKey(x=>x.SubeID);

            HasRequired(x => x.Egitim).WithMany(x => x.Siniflar).HasForeignKey(x => x.EgitimID);
            


        }
    }
}
