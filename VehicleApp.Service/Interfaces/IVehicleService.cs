using System;
using System.Collections.Generic;
using VehicleApp.Model;

namespace VehicleApp.Service.Interfaces
{
    public interface IVehicleService
    {
        void Add(VehicleModel v);
        void Edit(VehicleModel v);
        void Remove(int Id);
        IEnumerable<VehicleModel> GetAll();
        VehicleModel FindById(int Id);
    }
}
