using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class YoklamaMapping: EntityTypeConfiguration<Yoklama>
    {
        public YoklamaMapping()
        {
            HasKey(x => x.YoklamaID);
            HasRequired(x => x.Ogrenci).WithMany(x => x.Yoklamalar).HasForeignKey(x => x.OgrenciID);

        }
    }
}
