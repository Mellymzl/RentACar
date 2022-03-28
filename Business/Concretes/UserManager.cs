using AutoMapper;
using Business.Abstracts;
using Business.Dtos;
using Core.Entities;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IUserOperationClaimDal _userOperation;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IUserOperationClaimDal userOperation, IMapper mapper)
        {
            _userDal = userDal;
            _userOperation = userOperation;
            _mapper = mapper;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<UserListDto> GetAll()
        {
            return _mapper.Map<List<UserListDto>>(_userDal.GetList());
        }

        public void AddUserClaim(UserOperationClaim userOperationClaim)
        {
            _userOperation.Add(userOperationClaim);
        }

        public List<UserOperationClaimDto> GetUserClaim()

        { 
            return _mapper.Map<List<UserOperationClaimDto>>(_userOperation.GetAllUserClaim());
        }
    }
}
