using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class ExperienceComponents:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
