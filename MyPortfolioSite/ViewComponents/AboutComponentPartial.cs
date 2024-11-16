using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
