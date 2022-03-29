using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class UserClaimAddRequest
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
