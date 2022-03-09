using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Dtos;
using Business.Request;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarMaintenanceManager : ICarMaintenanceService
    {
        ICarMaintenanceDal  _carMaintenancesDal;
        IMapper _mapper;

        CarMaintenanceBusinessRules _carMaintenance;
        public CarMaintenanceManager(ICarMaintenanceDal carMaintenancesDal, IMapper mapper, CarMaintenanceBusinessRules carMaintenance)
        {
            _carMaintenancesDal = carMaintenancesDal;
            _mapper = mapper;
            _carMaintenance = carMaintenance;
        }

        public void Add(CreateCarMaintenancesRequest carMain)
        {
            ValidationTool.Validate(new CreateCarMaintenanceValidator(), carMain);
           _carMaintenance.CheckIfCarMaintenanceCarExists(carMain.CarId);
            CarMaintenance carM_ = _mapper.Map<CarMaintenance>(carMain);
            _carMaintenancesDal.Add(carM_);
        }

        public void Delete(DeleteCarMaintenancesRequest carMain)
        {
            CarMaintenance carM_ = _mapper.Map<CarMaintenance>(carMain);
            _carMaintenancesDal.Delete(carM_);
        }

        public List<CarMaintenancesDto> GetAll()
        {
            return _mapper.Map<List<CarMaintenancesDto>>(_carMaintenancesDal.GetAllwithCar());
        }

        public List<CarMaintenancesDto> GetByCarId(int carId)
        {
            return _mapper.Map<List<CarMaintenancesDto>>(_carMaintenancesDal.GetList(a=>a.CarId==carId));
        }

        public void Update(UpdateCarMaintenancesRequest carMain)
        {
            ValidationTool.Validate(new UpdateCarMaintenanceValidator(), carMain);
            CarMaintenance carM_ = _mapper.Map<CarMaintenance>(carMain);
            _carMaintenancesDal.Update(carM_);
        }
    }
}
