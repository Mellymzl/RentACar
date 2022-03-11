using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarMaintenanceController : ControllerBase
    {
        ICarMaintenanceService _carMService;

        public CarMaintenanceController(ICarMaintenanceService carMService)
        {
            this._carMService = carMService;
        }
        [HttpGet("getall")]
        public List<CarMaintenancesDto> GetAll()
        {
            return _carMService.GetAll();

        }

        [HttpPost("add")]

        public void Add(CreateCarMaintenanceRequest createMCar)
        {
            _carMService.Add(createMCar);

        }
        [HttpPost("update")]

        public void Update(UpdateCarMaintenanceRequest updateMCar)
        {
            _carMService.Update(updateMCar);

        }
        [HttpPost("delete")]

        public void Delete(DeleteCarMaintenanceRequest deleteMCar)
        {
            _carMService.Delete(deleteMCar);

        }
        [HttpGet("getbycarid")]

        public void GetByCarId( int carId)
        {
            _carMService.GetByCarId(carId);

        }
    }
}
