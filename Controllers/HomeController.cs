using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.pageName = "Home";
            return View();
        }
    }
}
