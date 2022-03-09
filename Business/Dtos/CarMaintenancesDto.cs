using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos
{
    public class CarMaintenancesDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime SendDate { get; set; }

        public string  Car { get; set; }

       
    }
}
