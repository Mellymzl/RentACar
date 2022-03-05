using Business.Dtos;
using Business.Request;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        List<BrandDto> GetAll();

        void Add(CreateBrandRequest brand);
        void Update(UpdateBrandRequest brand);
        void Delete(DeleteBrandRequest brand);
    }
}
