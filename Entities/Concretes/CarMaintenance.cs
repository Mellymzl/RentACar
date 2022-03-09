using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public  class CarMaintenance : IEntity
    {

        public int Id { get; set; } 
        public string Description { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime SendDate { get; set; }

        public int CarId { get; set; }  

        public Car Car { get; set; }
    }
}
