using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public  class ColorBusinessRules
    {

        IColorDal _colorDal;

        public ColorBusinessRules(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void CheckIfColorNameExists(string colorName)
        {
            var color = _colorDal.Get(a => a.Name == colorName);
            if (color != null)
            { throw new BusinessException("Bu isimde daha önce renk eklenmiştir"); }


        }
    }
}
