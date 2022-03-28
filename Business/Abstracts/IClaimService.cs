using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IClaimService
    {
        void Add(OperationClaim claim);
      
        List<OperationClaim> GetAll();

    }
}
