using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CorporateCustomerBusinessRules
    {
        ICorporateCustomerDal _corporateDal;

        public CorporateCustomerBusinessRules(ICorporateCustomerDal corporateDal)
        {
            _corporateDal = corporateDal;
        }

        public void CheckIfCompanyNameExists(string companyName)
        {
            var kurum = _corporateDal.Get(a => a.CompanyName == companyName);
            if (kurum != null)
            { throw new BusinessException("Bu isimde kurum daha önce eklenmiştir"); }


        }
    }
}
