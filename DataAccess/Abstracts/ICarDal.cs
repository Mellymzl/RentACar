using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetAllWithColorAndBrand();

       
    }
}