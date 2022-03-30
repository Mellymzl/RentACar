using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class UserBusinessRules
    {

        IUserOperationClaimDal _userClaimDal;
        IUserDal _userDal;

        public UserBusinessRules(IUserOperationClaimDal userClaimDal, IUserDal userDal)
        {
            _userClaimDal = userClaimDal;
            _userDal = userDal;
        }

        public void CheckIfUserExists(string email, string fname,string lname)
        {
            var user = _userDal.Get(p => p.Email==email&&p.FirstName==fname&&p.LastName==lname);
            if (user != null)
            { throw new BusinessException("Bu kullanıcı daha önce eklenmiştir."); }

        }

        public void CheckIfUserClaimExists(int userId, int claimID)
        {
            var userOperationClaim = _userClaimDal.Get(p => p.UserId == userId && p.OperationClaimId == claimID);
            if (userOperationClaim != null)
            { throw new BusinessException("Bu kullanıcıya yetki daha önce verilmiştir."); }

        }
    }
}

