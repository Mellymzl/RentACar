using AutoMapper;
using Business.Dtos;
using Business.Request;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    internal class CarMaintenanceProfiles : Profile
    {
        public CarMaintenanceProfiles()
        {
            CreateMap<CarMaintenance, CarMaintenancesDto>()
               .ForMember(p => p.Car, opt => opt.MapFrom(p => p.Car.Name))
             
               .ReverseMap();

            CreateMap<CarMaintenance, CreateCarMaintenancesRequest>()
                 .ForMember(p => p.CarId, opt => opt.MapFrom(p => p.Car.Id))
                
                 .ReverseMap();
            CreateMap<CarMaintenance, UpdateCarMaintenancesRequest>()
               .ForMember(p => p.CarId, opt => opt.MapFrom(p => p.Car.Id))

               .ReverseMap();
            CreateMap<CarMaintenance, DeleteCarMaintenancesRequest>()
              
               .ReverseMap();

        }
    }
}
