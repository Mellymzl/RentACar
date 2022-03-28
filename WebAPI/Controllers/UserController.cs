using Business.Abstracts;
using Business.Dtos;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public List<UserListDto> GetAll()
        {
            return _userService.GetAll();

        }


        [HttpPost("setuserclaim")]
        public ActionResult SetUserClaim( UserOperationClaim userOperationClaim)
        {
            _userService.AddUserClaim( userOperationClaim);
            return Ok();
        }
        [HttpGet("getuserclaim")]
        public List<UserOperationClaimDto> GetUsersClaim()
        {
           return  _userService.GetUserClaim();
          
        }

    }
}
