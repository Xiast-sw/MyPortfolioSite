using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
