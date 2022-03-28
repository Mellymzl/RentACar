using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, RentACarContext>, IUserOperationClaimDal
    {
        public List<UserOperationClaim> GetAllUserClaim()
        {
          
                using (RentACarContext context = new RentACarContext())
                {

                    return context.UserOperationClaims.Include(i =>i.OperationClaim).Include(i => i.User).ToList();

                }
          
        }
    }
}
