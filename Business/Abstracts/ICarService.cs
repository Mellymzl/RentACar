using Business.Dtos;
using Business.Request;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICarService
    {
        List<CarDto> GetAll();
        List<CarDto> GetByBrandId(int BrandId);
        GetCarDto GetById(int id);
        void Add(CreateCarRequest car);
        void Update(UpdateCarRequest car);
        void Delete(DeleteCarRequest car);

       
    }
}
