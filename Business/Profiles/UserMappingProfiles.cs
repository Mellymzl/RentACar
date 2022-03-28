using AutoMapper;
using Business.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserMappingProfiles:Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<User, UserListDto>().ReverseMap();
            CreateMap<UserOperationClaim, UserOperationClaimDto>()
                .ForMember(p => p.FirstName, opt => opt.MapFrom(p => p.User.FirstName))
                .ForMember(p => p.LastName, opt => opt.MapFrom(p => p.User.LastName))
                .ForMember(p => p.ClaimName, opt => opt.MapFrom(p => p.OperationClaim.Name))
                .ReverseMap();


        }

    }
}
