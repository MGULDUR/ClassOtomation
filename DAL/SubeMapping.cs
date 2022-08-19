using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubeMapping : EntityTypeConfiguration<Sube>
    {
        public SubeMapping()
        {
            HasKey(x => x.SubeID);
            Property(x => x.SubeAdi).IsRequired();
            Property(x => x.SubeMail).IsRequired();
            Property(x => x.SubeTelefon).IsRequired();
            Property(x => x.SubeAdresi).IsRequired();
        }
    }
}
