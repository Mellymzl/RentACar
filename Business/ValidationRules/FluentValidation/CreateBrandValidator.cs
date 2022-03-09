using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public  class CreateBrandValidator:AbstractValidator<CreateBrandRequest>          
    {

        public CreateBrandValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MaximumLength(70).MinimumLength(2);

        }

    }
}
