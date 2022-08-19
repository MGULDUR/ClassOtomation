using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OgrenciMapping: EntityTypeConfiguration<Ogrenci>
    {
        public OgrenciMapping()
        {
            HasKey(x => x.OgrenciID);
            Property(x => x.Foto).IsOptional();

            HasRequired(x => x.Sinif).WithMany(x => x.Ogrenciler).HasForeignKey(x => x.SinifKodu);
        }
    }
}
