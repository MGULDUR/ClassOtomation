using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KoordinatorMapping : EntityTypeConfiguration<Koordinator>
    {
        public KoordinatorMapping()
        {
            HasKey(x => x.KoordinatorID); // Identity Spec.
            Property(x => x.KoordinatorID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SubeID).IsOptional();

            //HasRequired(x => x.Sube).WithRequiredPrincipal(x => x.Koordinator);
            //HasRequired(x => x.Sube).WithMany(x => x.Koordinatorler).HasForeignKey(x => x.SubeID);
        }
    }
}
