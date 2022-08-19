using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-939HM83; Database=PersonelIletisim;User Id=sa;Password=123";


        }
        public DbSet<Egitmen> Egitmenler { get; set; }
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Koordinator> Koordinatorler { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<SiniflarEgitmenler> SiniflarEgitmenler { get; set; }
        public DbSet<Yoklama> Yoklamalar { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new EgitimMapping());
            modelBuilder.Configurations.Add(new EgitmenMapping());
            modelBuilder.Configurations.Add(new KoordinatorMapping());
            modelBuilder.Configurations.Add(new OgrenciMapping());
            modelBuilder.Configurations.Add(new SinifMapping());
            modelBuilder.Configurations.Add(new SubeMapping());
            modelBuilder.Configurations.Add(new YoneticiMapping());         
            modelBuilder.Configurations.Add(new SiniflarEgitmenlerMapping());
            modelBuilder.Configurations.Add(new YoklamaMapping());
            modelBuilder.Entity<Sube>().HasMany(x => x.Koordinatorler).WithOptional(x => x.Sube).HasForeignKey(x => x.SubeID);
            modelBuilder.Entity<Egitmen>().Property(x => x.Foto).HasColumnType("image");
            modelBuilder.Entity<Ogrenci>().Property(x => x.Foto).HasColumnType("image");
            modelBuilder.Entity<Koordinator>().Property(x => x.Foto).HasColumnType("image");
            modelBuilder.Entity<Yonetici>().Property(x => x.Foto).HasColumnType("image");


            #region Eğitmen ile şubeyi bağlayabilmek için basamaklı silme işlemini etkinleştirdik.
            // https://docs.microsoft.com/tr-tr/ef/ef6/modeling/code-first/fluent/relationships

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 
            #endregion

            //modelBuilder.Entity<Egitim>().HasMany(x => x.Siniflar).WithMany(x => x.Egitimler).Map(x =>
            //{
            //    x.ToTable("EgitimlerSiniflar");
            //    x.MapLeftKey("EgitimID");
            //    x.MapRightKey("SinifID");
            //});

            //modelBuilder.Entity<Sinif>().HasMany(x => x.Egitmenler).WithMany(x => x.Siniflar).Map(x =>
            //{
            //    x.ToTable("SiniflarEgitmenler");
            //    x.MapLeftKey("SinifID");
            //    x.Key("IsActive");
            //    x.MapRightKey("EgitmenID");
            //});


            base.OnModelCreating(modelBuilder);
        }
    }
}
