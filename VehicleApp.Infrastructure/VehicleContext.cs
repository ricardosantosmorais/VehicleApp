using System;
using System.Data.Entity;
using VehicleApp.Core;

namespace VehicleApp.Infrastructure
{
    [DbConfigurationType(typeof(EntityFrameworkDbConfiguration))]
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base("VehicleAppConnectionString")
        {
            var ensureDLLIsCopied = 
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;  
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new VehicleInitalizeDB());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
