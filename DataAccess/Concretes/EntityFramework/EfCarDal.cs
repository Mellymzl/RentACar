using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<Car> GetAllWithColorAndBrand()
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.Cars.Include(i => i.Brand).Include(i => i.Color).ToList();

            }
        }
        public List<Car> GetAllWithBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.Cars.Where(w=>w.BrandId==brandId).Include(i => i.Brand).Include(i => i.Color).ToList();

            }
        }
        public List<Car> GetAllWithColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.Cars.Where(w=>w.ColorId==colorId).Include(i => i.Brand).Include(i => i.Color).ToList();

            }
        }
        public Car GetCarById(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {

                return context.Cars.Where(w=>w.Id==id).Include(i => i.Brand).Include(i => i.Color).FirstOrDefault();

            }
        }
    }
}
