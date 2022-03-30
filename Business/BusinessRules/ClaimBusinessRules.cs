using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ClaimBusinessRules
    {

        IClaimDal _claimDal;

        public ClaimBusinessRules(IClaimDal claimDal)
        {
            _claimDal = claimDal;
        }

        public void CheckIfClaimNameExists(string name)
        {
            var car = _claimDal.Get(p => p.Name==name);
            if (car != null)
            { throw new BusinessException("Bu isimde rol daha önce  eklenmiştir"); }

        }
    }
}
