using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class BrandController : Controller
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            this._brandService = brandService;
        }

        public IActionResult Index()
        {
          
            return View(this._brandService.GetAll());
        }
    }
}
