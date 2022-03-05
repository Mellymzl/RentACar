using Business.Dtos;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Request;

namespace Business.Profiles
{
    public class BrandMappingProfiles:Profile
    {
        public BrandMappingProfiles()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandRequest>().ReverseMap();
            CreateMap<Brand, UpdateBrandRequest>().ReverseMap();
            CreateMap<Brand, DeleteBrandRequest>().ReverseMap();
        }
    }
}
