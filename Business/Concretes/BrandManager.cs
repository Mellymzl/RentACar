using AutoMapper;
using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using DataAccess.Abstracts;
using Entities.Concretes;
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

        public BrandManager(IBrandDal brandDal, IMapper mapper)
        {
            _brandDal = brandDal;
            _mapper = mapper;   
        }

        public void Add(CreateBrandRequest brand)
        {
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
            Brand brand_ = _mapper.Map<Brand>(brand);
            _brandDal.Update(brand_);
        }
    }
}
