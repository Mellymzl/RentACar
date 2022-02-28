using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
