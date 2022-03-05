using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            this._carService = carService;
        }
        [HttpGet("getall")]
        public List <CarDto> GetAll()
        {
            return _carService.GetAll();    

        }
        
        [HttpPost("add")]

        public void Add( CreateCarRequest createCar)
        {
           if(! _carService.Check(createCar))
          _carService.Add( createCar);    

        }
        [HttpPost("update")]

        public void Update(UpdateCarRequest updateCar)
        {
            _carService.Update(updateCar);

        }
        [HttpPost("delete")]

        public void Delete(DeleteCarRequest deleteCar)
        {
            _carService.Delete(deleteCar);

        }
    }
}
