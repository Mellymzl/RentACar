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
    public  class CarMappingProfiles: Profile
    {
        public CarMappingProfiles()
        {
            CreateMap<Car, CarDto>()
                .ForMember(p=>p.Brand, opt=>opt.MapFrom(p=>p.Brand.Name))
                .ForMember(p=>p.Color, opt=>opt.MapFrom(p=>p.Color.Name))
                .ReverseMap();

            CreateMap<Car, CreateCarRequest>()
                 .ForMember(p => p.BrandId, opt => opt.MapFrom(p => p.Brand.Id))
                 .ForMember(p => p.ColorId, opt => opt.MapFrom(p => p.Color.Id))
                 .ReverseMap();
             CreateMap<Car, UpdateCarRequest>()
                 .ForMember(p => p.BrandId, opt => opt.MapFrom(p => p.Brand.Id))
                 .ForMember(p => p.ColorId, opt => opt.MapFrom(p => p.Color.Id))
                 .ReverseMap();
            CreateMap<Car, DeleteCarRequest>()
                
                 .ReverseMap();
                 
               
        }  

    }
}
