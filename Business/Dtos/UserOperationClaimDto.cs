using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos
{
    public class UserOperationClaimDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public string ClaimName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }

    }
}
