using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CarMaintenanceBusinessRules
    {
        ICarMaintenanceDal _carMaintenanceDal;

        public CarMaintenanceBusinessRules(ICarMaintenanceDal carMaintenanceDal)
        {
            _carMaintenanceDal = carMaintenanceDal;
        }

        public void CheckIfCarMaintenanceCarExists(int carId)
        {
            var carM = _carMaintenanceDal.Get(p => p.Id == carId && p.ReturnDate ==null);
            if (carM != null)
            { throw new BusinessException("Bu araç bakımdadır."); }


        }
    }
}
