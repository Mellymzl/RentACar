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
    internal class CorporateCustomerManager : ICorporateCustomerService
    {
        ICorporateCustomerDal _corporateDal;
        IMapper _mapper;
        CorporateCustomerBusinessRules _corporateBusinessRules;

        public CorporateCustomerManager(ICorporateCustomerDal corporateDal, IMapper mapper, CorporateCustomerBusinessRules corporateBusinessRules)
        {
            _corporateDal = corporateDal;
            _mapper = mapper;
            _corporateBusinessRules = corporateBusinessRules;
        }

        public void Add(CreateCorporateCustomerRequest corporateCustomer)
        {
            ValidationTool.Validate(new CreateCorporateCustomerValidator(), corporateCustomer);
            _corporateBusinessRules.CheckIfCompanyNameExists(corporateCustomer.CompanyName);
            CorporateCustomer customer   = _mapper.Map<CorporateCustomer>(corporateCustomer);
            _corporateDal.Add(customer);
        }

        public void Delete(DeleteCorporateCustomerRequest corporateCustomer)
        {
            CorporateCustomer customer = _mapper.Map<CorporateCustomer>(corporateCustomer);
            _corporateDal.Delete(customer);
        }

        public List<CorporateCostomerDto> GetAll()
        {
            return _mapper.Map<List<CorporateCostomerDto>>(_corporateDal.GetList());
        }

        public void Update(UpdateCorporateCustomerRequest corporateCustomer)
        {
            ValidationTool.Validate(new UpdateCorporateCustomerValidator(), corporateCustomer);           
            CorporateCustomer customer = _mapper.Map<CorporateCustomer>(corporateCustomer);
            _corporateDal.Update(customer);
        }
    }
}
