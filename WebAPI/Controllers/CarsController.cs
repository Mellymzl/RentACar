﻿using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public List <CarDto> GetAll()
        {
            return _carService.GetAll();    

        }
        
        [HttpPost("add")]

        public void Add( CreateCarRequest createCar)
        {
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
        [HttpPost("getbyid/{id}")]

        public GetCarDto GetById([FromRoute] int id)
        {
            return _carService.GetById(id);

        }

        [HttpGet("getallbybrandid/{brandid}")]
        public List<CarDto> GetByBrandId([FromRoute] int brandid)
        {
            return _carService.GetByBrandId(brandid);

        }
        [HttpGet("getallbycolorid/{colorid}")]
        public List<CarDto> GetByColorId([FromRoute] int colorid)
        {
            return _carService.GetByColorId(colorid);

        }
    }
}
