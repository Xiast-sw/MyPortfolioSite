using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
