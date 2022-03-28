using Business.Abstracts;
using Core.Entities;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ClaimManager : IClaimService
    {

        private IClaimDal _claimDal;

        public ClaimManager(IClaimDal claimDal)
        {
            _claimDal = claimDal;
        }

        public void Add(OperationClaim claim)
        {
            _claimDal.Add(claim);
        }

        public List<OperationClaim> GetAll()
        {
            return _claimDal.GetList();
        }
    }
}
