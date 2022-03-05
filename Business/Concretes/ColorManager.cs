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
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;
        IMapper _mapper;

        public ColorManager(IColorDal colorDal,IMapper mapper)
        {
            _colorDal = colorDal;
            _mapper = mapper;   
        }

        public void Add(CreateColorRequest color)
        {
            Color color_ = _mapper.Map<Color>(color);
            _colorDal.Add(color_);
        }

        public void Delete(DeleteColorRequest color)
        {
            Color color_ = _mapper.Map<Color>(color);
            _colorDal.Delete(color_);
        }

        public List<ColorDto> GetAll()
        {
            return _mapper.Map <List < ColorDto>>( _colorDal.GetList());
        }

        public void Update(UpdateColorRequest color)
        {
            Color color_ = _mapper.Map<Color>(color);
            _colorDal.Update(color_);
        }
    }
}
