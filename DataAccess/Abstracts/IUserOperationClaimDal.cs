﻿using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimDal :  IEntityRepository<UserOperationClaim>
    {

        List<UserOperationClaim> GetAllUserClaim();
    }
}
