using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class CreateIndividualCustomerRequest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentityNumber { get; set; }

        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
