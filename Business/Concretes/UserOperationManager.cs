using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserOperationManager : IUserOperationService
    {
        IUserOperationDal _userOperationDal;

        public UserOperationManager(IUserOperationDal userOperationDal)
        {
            _userOperationDal = userOperationDal;
        }

        public List<UserOperation> GetOperationAndUserOperations()
        {
           return  _userOperationDal.GetOperationAndUserOperations();
        }
    }
}
