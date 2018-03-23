using System;
using System.Collections.Generic;

namespace VehicleApp.Core.Interfaces
{
    public interface IVehicleRepository
    {
        void Add(Vehicle v);
        void Edit(Vehicle v);
        void Remove(int Id);
        IEnumerable<Vehicle> GetAll(); 
        Vehicle FindById(int Id);
    }
}
