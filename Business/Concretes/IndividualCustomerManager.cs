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
    internal class IndividualCustomerManager: IIndividualCustomerService
    {
        IIndividualCustomerDal _individualDal;
        IMapper _mapper;
        IndividualCustomerBusinessRules _individiualBusinessRules;

        public IndividualCustomerManager(IIndividualCustomerDal individualDal, IMapper mapper, IndividualCustomerBusinessRules individiualBusinessRules)
        {
            _individualDal = individualDal;
            _mapper = mapper;
            _individiualBusinessRules = individiualBusinessRules;
        }

     
        public void Add(CreateIndividualCustomerRequest individualCostomer)
        {
            ValidationTool.Validate(new CreateIndividualCustomerValidator(), individualCostomer);
            _individiualBusinessRules.CheckIfCustomerNameExists(individualCostomer.CustomerFirstName, individualCostomer.CustomerLastName);
            IndividualCustomer customer = _mapper.Map<IndividualCustomer>(individualCostomer);
            _individualDal.Add(customer);
        }

       
        public void Delete(DeleteIndividualCustomerRequest individualCostomer)
        {
             IndividualCustomer customer = _mapper.Map<IndividualCustomer>(individualCostomer);
            _individualDal.Delete(customer);
        }

        
       
        public void Update(UpdateIndividualCustomerRequest individualCostomer)
        {
            ValidationTool.Validate(new UpdateIndividualCustomerValidator(), individualCostomer);
             IndividualCustomer customer = _mapper.Map<IndividualCustomer>(individualCostomer);
            _individualDal.Update(customer);
        }

        List<IndividualCostomerDto> IIndividualCustomerService.GetAll()
        {
            return _mapper.Map<List<IndividualCostomerDto>>(_individualDal.GetList());
        }
    }
}
