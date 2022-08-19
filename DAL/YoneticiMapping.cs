using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class YoneticiMapping : EntityTypeConfiguration<Yonetici>
    {
        public YoneticiMapping()
        {
            HasKey(x => x.YoneticiID);
        }

    }
}
