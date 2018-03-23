using System;
using System.Data.Entity;

namespace VehicleApp.Infrastructure
{
    public class VehicleInitalizeDB : DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            context.Vehicles.Add(new Core.Vehicle { Brand = "Ford", Color = "Verde", Year = 2010, Model = "Fiesta", Price = 30000, Description = "Ford New Fiesta", Isnew = false, DateCreated = DateTime.UtcNow, DateUpdated = DateTime.UtcNow });
            base.Seed(context);
        }
    }
}
