using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<Car> GetAllWithColorAndBrand()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return context.Cars.Include(i => i.Brand).Include(i => i.Color).ToList();

            }
        }

        public bool CheckCar( Car car)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return context.Cars.Where(w=>w.Name==car.Name).FirstOrDefault()==null?false:true;

            }
        }
    }
}
