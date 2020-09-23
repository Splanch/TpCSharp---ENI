using BODojo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP1_Mod6_Dojo.Data
{
    public class TP1_Mod6_DojoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TP1_Mod6_DojoContext() : base("name=TP1_Mod6_DojoContext")
        {
        }

        public System.Data.Entity.DbSet<BODojo.Arme> Armes { get; set; }

        public System.Data.Entity.DbSet<BODojo.Samourai> Samourais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samourai>().HasOptional(v => v.Arme).WithOptionalPrincipal();
            modelBuilder.Entity<Samourai>().HasMany(x => x.ArtMartials).WithMany();
            modelBuilder.Entity<Samourai>().Ignore(p => p.Potentiel);
        }

        public System.Data.Entity.DbSet<BODojo.ArtMartial> ArtMartials { get; set; }
    }
}
