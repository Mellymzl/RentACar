using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualCustomerController : ControllerBase
    {

        IIndividualCustomerService _individualCustomerService;

        public IndividualCustomerController(IIndividualCustomerService ındividualCustomerService)
        {
            this._individualCustomerService = ındividualCustomerService;
        }

        [HttpGet("getall")]
        public List<IndividualCostomerDto> GetAll()
        {
            return _individualCustomerService.GetAll();

        }

        [HttpPost("add")]

        public void Add(CreateIndividualCustomerRequest createIndividual)
        {
            _individualCustomerService.Add(createIndividual);

        }
        [HttpPost("update")]

        public void Update(UpdateIndividualCustomerRequest updateIndividual)
        {
            _individualCustomerService.Update(updateIndividual);

        }
        [HttpPost("delete")]

        public void Delete(DeleteIndividualCustomerRequest deleteIndividual)
        {
            _individualCustomerService.Delete(deleteIndividual);

        }
    }
}
