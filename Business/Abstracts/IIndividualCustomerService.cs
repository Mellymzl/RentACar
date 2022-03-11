using Business.Dtos;
using Business.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
   public interface  IIndividualCustomerService
    {
        List<IndividualCostomerDto> GetAll();

        void Add(CreateIndividualCustomerRequest individualCostomer);
        void Update(UpdateIndividualCustomerRequest individualCostomer);
        void Delete(DeleteIndividualCustomerRequest individualCostomer);
    }
}
