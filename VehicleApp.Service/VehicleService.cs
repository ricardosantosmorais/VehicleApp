using System;
using System.Collections.Generic;
using AutoMapper;
using VehicleApp.Core;
using VehicleApp.Core.Interfaces;
using VehicleApp.Infrastructure.Repository;
using VehicleApp.Model;
using VehicleApp.Service.Interfaces;
using VehicleApp.Service.Mappers;

namespace VehicleApp.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService() {
            vehicleRepository = new VehicleRepository();
            _mapper = AutoMapperConfig.Mapper;
        }

        public void Add(VehicleModel v)
        {
            var obj = _mapper.Map<Vehicle>(v);
            obj.DateCreated = DateTime.Now;
            obj.DateUpdated = DateTime.Now;
            vehicleRepository.Add(obj);
        }

        public void Edit(VehicleModel v)
        {
            var obj = _mapper.Map<Vehicle>(v);
            obj.DateUpdated = DateTime.Now;
            vehicleRepository.Edit(obj);
        }

        public VehicleModel FindById(int Id)
        {
            return _mapper.Map<VehicleModel>(vehicleRepository.FindById(Id));
        }

        public IEnumerable<VehicleModel> GetAll()
        {
            return _mapper.Map<IEnumerable<VehicleModel>>(vehicleRepository.GetAll());
        }

        public void Remove(int Id)
        {
            vehicleRepository.Remove(Id);
        }
    }
}
