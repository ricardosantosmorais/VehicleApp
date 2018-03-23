using System;
using AutoMapper;
using VehicleApp.Core;
using VehicleApp.Model;

namespace VehicleApp.Service.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VehicleModel, Vehicle>();
        }
    }
}
