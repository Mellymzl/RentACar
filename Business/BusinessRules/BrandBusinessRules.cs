using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class BrandBusinessRules
    {
        IBrandDal _brandDal;

        public BrandBusinessRules(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void CheckIfBrandNameExists(string brandName)
        {
            var brand = _brandDal.Get(a => a.Name == brandName);

            if (brand != null)
            { throw new BusinessException("Bu isimde daha önce marka eklenmiştir"); }

        }
    }
}
