using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos
{
    public class UserOperationDto
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Operation { get; set; }         

    }
}
