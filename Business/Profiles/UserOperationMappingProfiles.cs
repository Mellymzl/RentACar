using AutoMapper;
using Business.Dtos;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserOperationMappingProfiles:Profile
    {

        public UserOperationMappingProfiles()
        {
            CreateMap<UserOperation, UserOperationDto>()
                   .ForMember(p => p.UserName, opt => opt.MapFrom(p =>( p.User.FirstName+" "+p.User.LastName) ))
                   .ForMember(p => p.Operation, opt => opt.MapFrom(p => p.Operation.Name))
                   .ReverseMap();

        }
    }
}
