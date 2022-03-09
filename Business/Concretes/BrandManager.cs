using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Dtos;
using Business.Request;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService

    {

        IBrandDal _brandDal;
        IMapper _mapper;
        BrandBusinessRules _brandBusinessRoles;
        public BrandManager(IBrandDal brandDal, IMapper mapper, BrandBusinessRules brandBusinessRoles)
        {
            _brandDal = brandDal;
            _mapper = mapper; 
            _brandBusinessRoles = brandBusinessRoles;
            
        }

        public void Add(CreateBrandRequest brand)
        {
            ValidationTool.Validate(new CreateBrandValidator(), brand);
            _brandBusinessRoles.CheckIfBrandNameExists(brand.Name);
            Brand brand_ = _mapper.Map<Brand>(brand);
            _brandDal.Add(brand_);
        }

        public void Delete(DeleteBrandRequest brand)
        {
            Brand brand_ = _mapper.Map<Brand>(brand);
            _brandDal.Delete(brand_);
        }

        public List<BrandDto> GetAll()
        {
            return _mapper.Map < List< BrandDto >> (_brandDal.GetList());
        }

        public void Update(UpdateBrandRequest brand)
        {

            ValidationTool.Validate(new UpdateBrandValidator(), brand);
            Brand brand_ = _mapper.Map<Brand>(brand);
            _brandDal.Update(brand_);
        }
    }
}
