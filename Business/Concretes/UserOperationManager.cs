using AutoMapper;
using Business.Abstracts;
using Business.Dtos;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserOperationManager : IUserOperationService
    {
        IUserOperationDal _userOperationDal;
        IMapper _mapper;

        public UserOperationManager(IUserOperationDal userOperationDal, IMapper mapper)
        {
            _userOperationDal = userOperationDal;
            _mapper = mapper;
        }

        public List<UserOperationDto> GetUserOperations()
        {

            return _mapper.Map<List<UserOperationDto>>(_userOperationDal.GetUserOperations());
       
        }
        public List<UserOperationDto> GetUserOperations(int userId)
        {

            return _mapper.Map<List<UserOperationDto>>(_userOperationDal.GetUserOperations(userId));

        }

        public UserOperationDto GetUserOperation(string operation)
        {

            return _mapper.Map<UserOperationDto>(_userOperationDal.GetUserOperation(operation));

        }
    }
}
