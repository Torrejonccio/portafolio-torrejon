using Microsoft.AspNetCore.Mvc;

namespace PortfolioPagina.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}