using Business.Abstracts;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {


        private IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet("getall")]
        public List<OperationClaim> GetAll()
        {
            return _claimService.GetAll();

        }
        [HttpPost("add")]
        public ActionResult Add(OperationClaim claim)
        {
            _claimService.Add(claim);
            return Ok();

        }
    }
}
