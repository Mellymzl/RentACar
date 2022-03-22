using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public  class AplicationUser:User,IEntity
    {


        public List<IndividualCustomer> IndividualCustomers { get; set; }
        public List<CorporateCustomer> CorporateCustomers { get; set; }
    }
}
