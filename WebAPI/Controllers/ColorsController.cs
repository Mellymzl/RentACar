using Business.Abstracts;
using Business.Dtos;
using Business.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            this._colorService = colorService;
        }
        [HttpGet("getall")]
        public List<ColorDto> GetAll()
        {
            return _colorService.GetAll();

        }
        [HttpPost("add")]
        public void Add(CreateColorRequest createColor)
        {
            _colorService.Add(createColor);

        }
        [HttpPost("update")]

        public void Update(UpdateColorRequest updateColor)
        {
            _colorService.Update(updateColor);

        }
        [HttpPost("delete")]

        public void Delete(DeleteColorRequest deleteColor)
        {
            _colorService.Delete(deleteColor);

        }
    }
}
