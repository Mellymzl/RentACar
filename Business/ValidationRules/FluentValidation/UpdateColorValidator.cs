using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateColorValidator:AbstractValidator<UpdateColorRequest>
    {
        public UpdateColorValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.Id).NotEmpty();
        }
    }
}
