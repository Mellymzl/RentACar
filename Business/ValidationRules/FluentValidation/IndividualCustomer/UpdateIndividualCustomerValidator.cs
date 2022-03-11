using Business.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdateIndividualCustomerValidator : AbstractValidator<UpdateIndividualCustomerRequest >
    {

        public UpdateIndividualCustomerValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.LastName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(r => r.NationalIdentityNumber).NotEmpty().Length(11);
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.EMail).NotEmpty();
            RuleFor(r => r.UserName).NotEmpty().MinimumLength(2).MaximumLength(50);

        }
    }
}
