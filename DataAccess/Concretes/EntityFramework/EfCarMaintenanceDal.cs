using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarMaintenanceDal : EfEntityRepositoryBase<CarMaintenance, RentACarContext>, ICarMaintenanceDal
    {
        public List<CarMaintenance> GetAllwithCar()
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.CarMaintenances.Include(i=>i.Car). ToList();

            }
        }

       
    }
}
