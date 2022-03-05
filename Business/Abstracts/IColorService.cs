using Business.Dtos;
using Business.Request;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IColorService
    {
        List<ColorDto> GetAll();

        void Add(CreateColorRequest color);
        void Update(UpdateColorRequest color);
        void Delete(DeleteColorRequest color);
    }
}
