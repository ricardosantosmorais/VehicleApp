using System;
using System.Collections;
using VehicleApp.Core;
using VehicleApp.Core.Interfaces;
using System.Collections.Generic;

namespace VehicleApp.Infrastructure.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        VehicleContext context = new VehicleContext();

        public void Add(Vehicle v)
        {
            context.Vehicles.Add(v);
            context.SaveChanges();
        }

        public void Edit(Vehicle p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Vehicle FindById(int Id)
        {
            var result = context.Vehicles.Find(Id);
            return result;
        }

        public IEnumerable<Vehicle> GetAll() 
        { 
            return context.Vehicles; 
        }

        public void Remove(int Id) 
        { 
            Vehicle p = context.Vehicles.Find(Id); context.Vehicles.Remove(p); context.SaveChanges(); 
        }
    }
}
