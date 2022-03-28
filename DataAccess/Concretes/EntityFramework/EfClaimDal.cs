using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.Contexts
{
    public class EfClaimDal : EfEntityRepositoryBase<OperationClaim, RentACarContext>, IClaimDal
    
    {
    }
}
