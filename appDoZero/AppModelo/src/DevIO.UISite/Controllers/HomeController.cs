using Microsoft.AspNetCore.Mvc;

namespace DevIO.UISite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
