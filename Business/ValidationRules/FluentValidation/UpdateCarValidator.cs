using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateCarValidator:AbstractValidator<UpdateCarRequest>
    {
        public UpdateCarValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.BrandId).NotEmpty();
            RuleFor(r => r.ColorId).NotEmpty();
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.DailyPrice).NotEmpty().GreaterThan(0);

        }
    }
}
