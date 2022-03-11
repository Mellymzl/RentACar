using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class IndividualCustomer:AplicationUser, IEntity
    {
      
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string NationalIdentityNumber { get; set; }
       
     
    }
}
