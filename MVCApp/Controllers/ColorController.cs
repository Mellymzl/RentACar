using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace MVCApp.Controllers
{
    public class ColorController : Controller
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            this._colorService = colorService;
        }

        public IActionResult Index()
        {

            return View(this._colorService.GetAll());
        }
    }
}
