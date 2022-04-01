using Core.DataAccess.EntityFramework;
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
        public List<UserOperation> GetOperationAndUserOperations()
        {

            using (RentACarContext context = new RentACarContext())
            {

                return context.UserOperations.Include(i => i.Operation).Include(i => i.User).ToList();

            }


        }
    }
}
