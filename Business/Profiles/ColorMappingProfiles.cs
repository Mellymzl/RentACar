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
    internal class ColorMappingProfiles : Profile
    {
        public ColorMappingProfiles()
        {
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Color, CreateColorRequest>().ReverseMap();
            CreateMap<Color, DeleteColorRequest>().ReverseMap();
            CreateMap<Color, UpdateColorRequest>().ReverseMap();
      
        }
    }
}
