using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetAllWithColorAndBrand();
        List<Car> GetAllWithColorId(int colorId);
        List<Car> GetAllWithBrandId(int brandId);
        Car GetCarById(int id);
       
    }
}