using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            this._brandService =brandService;
        }
        [HttpGet("getall")]
        public List<BrandDto> GetAll()
        {
            return _brandService.GetAll();

        }

        [HttpPost("add")]

        public void Add(CreateBrandRequest createBrand)
        {
            _brandService.Add(createBrand);

        }
        [HttpPost("update")]

        public void Update(UpdateBrandRequest updateBrand)
        {
            _brandService.Update(updateBrand);

        }
        [HttpPost("delete")]

        public void Delete(DeleteBrandRequest deleteBrand)
        {
            _brandService.Delete(deleteBrand);

        }
    }
}
