using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Dtos;
using Business.Request;
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
        UserBusinessRules _userBusinessRules;

        public UserManager(IUserDal userDal, IUserOperationClaimDal userOperation, IMapper mapper, UserBusinessRules userBusinessRules)
        {
            _userDal = userDal;
            _userOperation = userOperation;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userBusinessRules.CheckIfUserExists(user.Email , user.FirstName , user.LastName);
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

        public void AddUserClaim(UserClaimAddRequest userOperationClaim)
        {
            _userBusinessRules.CheckIfUserClaimExists(userOperationClaim.UserId, userOperationClaim.OperationClaimId);
            var userOperationClaim_ = _mapper.Map<UserOperationClaim>(userOperationClaim);
            _userOperation.Add(userOperationClaim_);
        }

        public List<UserOperationClaimDto> GetUserClaim()

        { 
            return _mapper.Map<List<UserOperationClaimDto>>(_userOperation.GetAllUserClaim());
        }
    }
}
