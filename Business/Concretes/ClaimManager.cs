using Business.Abstracts;
using Business.BusinessRules;
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
        ClaimBusinessRules _claimBusinessRules;

        public ClaimManager(IClaimDal claimDal, ClaimBusinessRules claimBusinessRules)
        {
            _claimDal = claimDal;
            this._claimBusinessRules = claimBusinessRules;
        }

        public void Add(OperationClaim claim)
        {
            _claimBusinessRules.CheckIfClaimNameExists(claim.Name);
            _claimDal.Add(claim);
        }

        public List<OperationClaim> GetAll()
        {
            return _claimDal.GetList();
        }
    }
}
