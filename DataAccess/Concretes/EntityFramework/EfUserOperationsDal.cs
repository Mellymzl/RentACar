using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserOperationsDal :
        EfEntityRepositoryBase<UserOperation,
            RentACarContext>, IUserOperationDal
    {
        public List<UserOperation> GetUserOperations()
        {

            using (RentACarContext context = new RentACarContext())
            {

                return context.UserOperations.Include(i => i.Operation).Include(i => i.User).ToList();

            }


        }

        public UserOperation GetUserOperation(string operation)
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.UserOperations.Include(i => i.Operation).Include(i => i.User).FirstOrDefault(i=>i.Operation.Name==operation);

            }
        }

        public List<UserOperation> GetUserOperations(int userId)
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.UserOperations.Include(i => i.Operation).Include(i => i.User).Where(w=>w.UserId==userId).ToList();

            }
        }
    }
}
