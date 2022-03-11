using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
    {
        IIndividualCustomerDal _individualDal;

        public IndividualCustomerBusinessRules(IIndividualCustomerDal individualDal)
        {
            _individualDal = individualDal;
        }

        public void CheckIfCustomerNameExists(string fname, string lname)
        {
            var kisi = _individualDal.Get(a => a.FirstName == fname&&a.LastName==lname);
            if (kisi != null)
            { throw new BusinessException("Bu isimde kişi daha önce eklenmiştir"); }


        }
    }
}
