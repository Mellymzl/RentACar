using Business.Dtos;
using Business.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICorporateCustomerService
    {
        List<CorporateCostomerDto> GetAll();

        void Add(CreateCorporateCustomerRequest corporateCustomer);
        void Update(UpdateCorporateCustomerRequest corporateCustomer);
        void Delete(DeleteCorporateCustomerRequest corporateCustomer);
    }
}
