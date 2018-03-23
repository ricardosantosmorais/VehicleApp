using System;
using AutoMapper;
using VehicleApp.Core;
using VehicleApp.Model;

namespace VehicleApp.Service.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Vehicle, VehicleModel>();
        }
    }
}
