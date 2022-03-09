using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateCarMaintenanceValidator : AbstractValidator<UpdateCarMaintenancesRequest>
    {
        public UpdateCarMaintenanceValidator()
        {
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.CarId).NotEmpty();
        }
    }
}
