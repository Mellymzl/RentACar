using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Dtos;
using Business.Request;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager:ICarService
    {

        ICarDal _carDal;
        IMapper _mapper;
        CarBusinessRules _carBusinessRules;

        public CarManager(ICarDal carDal,IMapper mapper, CarBusinessRules carBusinessRules)
        {
            _carDal = carDal;
            _mapper = mapper;
            _carBusinessRules = carBusinessRules;
        }

        public void Add(CreateCarRequest car)
        {
            ValidationTool.Validate(new CreateCarValidator(), car);
            _carBusinessRules.CheckIfCarNameExists(car.Name);
            Car car_ = _mapper.Map<Car>(car);
            _carDal.Add(car_);

        }
       
        public void Delete(DeleteCarRequest car)
        {
            Car car_ = _mapper.Map<Car>(car);
            _carDal.Delete(car_);
        }

        public List<CarDto> GetAll()
        {
            return _mapper.Map<List <CarDto>>( _carDal.GetAllWithColorAndBrand());
        }

        public void Update(UpdateCarRequest car)
        {
            ValidationTool.Validate(new UpdateCarValidator(), car);
            Car car_ = _mapper.Map<Car>(car);
            _carDal.Update(car_);
        }
    }
}
