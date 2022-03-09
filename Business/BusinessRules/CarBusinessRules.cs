using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CarBusinessRules
    {

        ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            this._carDal = carDal;
        }


        public void CheckIfCarNameExists(string carName)
        {
            var car = _carDal.Get(p => p.Name == carName);
            if (car != null)
            { throw new Exception("Bu isimde daha önce araba eklenmiştir"); }

        }
    }
}
