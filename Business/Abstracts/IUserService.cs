﻿using Business.Dtos;
using Business.Request;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        List<UserListDto> GetAll();

        void AddUserClaim(UserClaimAddRequest userOperationClaim);
        List<UserOperationClaimDto> GetUserClaim();





    }
}
