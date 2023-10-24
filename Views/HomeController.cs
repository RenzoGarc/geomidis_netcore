using Microsoft.AspNetCore.Mvc;

namespace GeomidisSystem.Views
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
