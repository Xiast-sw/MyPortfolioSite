using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
