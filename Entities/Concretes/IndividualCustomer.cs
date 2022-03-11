﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class IndividualCustomer:AplicationUser, IEntity
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentityNumber { get; set; }
       
     
    }
}
