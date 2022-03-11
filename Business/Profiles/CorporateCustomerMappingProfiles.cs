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
    public  class CorporateCustomerMappingProfiles:Profile
    {

        public CorporateCustomerMappingProfiles()
        {
            CreateMap<CorporateCustomer, CorporateCostomerDto>().
            ReverseMap();
            CreateMap<CorporateCustomer, CreateCorporateCustomerRequest>().ReverseMap();
            CreateMap<CorporateCustomer, DeleteCorporateCustomerRequest>().ReverseMap();
            CreateMap<CorporateCustomer, UpdateCorporateCustomerRequest>().ReverseMap();

        }
    }
}
