using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public  class CreateCarMaintenanceRequest
    {

        public string Description { get; set; }
        public DateTime SendDate { get; set; }

        public int CarId { get; set; }

    }
}
