using AutoMapper;
using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using DataAccess.Abstracts;
using Entities.Concretes;
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

        public CarManager(ICarDal carDal,IMapper mapper)
        {
            _carDal = carDal;
            _mapper = mapper;
        }

        public void Add(CreateCarRequest car)
        {

            Car car_ = _mapper.Map <Car>(car);
            _carDal.Add(car_);  
        }

        public bool Check(CreateCarRequest car)
        {
            Car car_ = _mapper.Map<Car>(car);
            return _carDal.CheckCar(car_);
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
            Car car_ = _mapper.Map<Car>(car);
            _carDal.Update(car_);
        }
    }
}
