using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class UpdateCorporateCustomerRequest
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }

        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
