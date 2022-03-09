using Business.Dtos;
using Business.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public  interface ICarMaintenanceService
    {
        List<CarMaintenancesDto> GetAll();
        List<CarMaintenancesDto> GetByCarId(int carId);

        void Add(CreateCarMaintenancesRequest carMain);
        void Update(UpdateCarMaintenancesRequest carMain);
        void Delete(DeleteCarMaintenancesRequest carMain);

    }
}
