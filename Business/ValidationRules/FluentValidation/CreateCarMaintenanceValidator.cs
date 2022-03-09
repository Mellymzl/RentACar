using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CreateCarMaintenanceValidator : AbstractValidator<CreateCarMaintenancesRequest>
    {
        public CreateCarMaintenanceValidator()
        {
            RuleFor(r => r.SendDate).NotEmpty();
            RuleFor(r => r.CarId).NotEmpty();
        }
    }
}
