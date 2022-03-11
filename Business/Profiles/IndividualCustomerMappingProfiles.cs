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
    public class IndividualCustomerMappingProfiles:Profile
    {
        public IndividualCustomerMappingProfiles()
        {
            CreateMap<IndividualCustomer, IndividualCostomerDto>().
             ReverseMap();
            CreateMap<IndividualCustomer, CreateIndividualCustomerRequest>().ReverseMap();
            CreateMap<IndividualCustomer, DeleteIndividualCustomerRequest>().ReverseMap();
            CreateMap<IndividualCustomer, UpdateIndividualCustomerRequest>().ReverseMap();

        }
    }
}
