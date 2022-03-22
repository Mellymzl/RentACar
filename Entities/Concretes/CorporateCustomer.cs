using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CorporateCustomer:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
      
        public AplicationUser AplicationUser { get; set; }


    }
}
