using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
