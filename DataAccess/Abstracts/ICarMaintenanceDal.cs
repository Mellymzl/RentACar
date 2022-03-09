using Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public  interface ICarMaintenanceDal : IEntityRepository<CarMaintenance>
    {

        List<CarMaintenance> GetAllwithCar();
    

    }
}
