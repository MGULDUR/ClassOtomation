using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EgitmenMapping : EntityTypeConfiguration<Egitmen>
    {
        public EgitmenMapping()
        {
            HasKey(x => x.EgitmenID);

            HasRequired(x => x.Sube).WithMany(x => x.Egitmenler).HasForeignKey(x => x.SubeID);
        }
    }
}
