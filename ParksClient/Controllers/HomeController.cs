using Microsoft.AspNetCore.Mvc;

namespace ParksClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
