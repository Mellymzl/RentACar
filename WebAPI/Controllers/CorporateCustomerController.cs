using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateCustomerController : ControllerBase
    {
        ICorporateCustomerService _customerService;

        public CorporateCustomerController(ICorporateCustomerService customerService)
        {
            this._customerService = customerService;
        }


        [HttpGet("getall")]
        public List<CorporateCostomerDto> GetAll()
        {
            return _customerService.GetAll();

        }

        [HttpPost("add")]

        public void Add(CreateCorporateCustomerRequest createCorporate)
        {
            _customerService.Add(createCorporate);

        }
        [HttpPost("update")]

        public void Update(UpdateCorporateCustomerRequest updateCorporate)
        {
            _customerService.Update(updateCorporate);

        }
        [HttpPost("delete")]

        public void Delete(DeleteCorporateCustomerRequest deleteCorporate)
        {
            _customerService.Delete(deleteCorporate);

        }
    }
}
