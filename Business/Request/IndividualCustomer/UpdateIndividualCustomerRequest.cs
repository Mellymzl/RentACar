using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class UpdateIndividualCustomerRequest
    {
        public int Id { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string NationalIdentityNumber { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }

    }
}
