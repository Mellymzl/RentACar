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
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;
        IMapper _mapper;
        ColorBusinessRules _colorBusinessRules;

        public ColorManager(IColorDal colorDal,IMapper mapper, ColorBusinessRules colorBusinessRules)
        {
            _colorDal = colorDal;
            _mapper = mapper;   
            _colorBusinessRules = colorBusinessRules;   
        }

        public void Add(CreateColorRequest color)
        {
            ValidationTool.Validate(new CreateColorValidator(), color);
            _colorBusinessRules.CheckIfColorNameExists(color.Name);
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
            ValidationTool.Validate(new UpdateColorValidator(), color);
            Color color_ = _mapper.Map<Color>(color);
            _colorDal.Update(color_);
        }
    }
}
