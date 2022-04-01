using Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserOperationDal :
        IEntityRepository<UserOperation>
    {
        List<UserOperation> GetUserOperations();
        List<UserOperation> GetUserOperations(int userId);
        UserOperation GetUserOperation(string operation);
    }
}
