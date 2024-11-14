using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
