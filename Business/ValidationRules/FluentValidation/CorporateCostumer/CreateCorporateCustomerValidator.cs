using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CreateCorporateCustomerValidator : AbstractValidator<CreateCorporateCustomerRequest>
    {
        public CreateCorporateCustomerValidator()
        {
            RuleFor(r => r.CompanyName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.TaxNumber).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.EMail).NotEmpty();
            RuleFor(r => r.UserName).NotEmpty().MinimumLength(2).MaximumLength(50);
        }
    }
}
