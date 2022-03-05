using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request
{
    public class CreateCarRequest
    {
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
