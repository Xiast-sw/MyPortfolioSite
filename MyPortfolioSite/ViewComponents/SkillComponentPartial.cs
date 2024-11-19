using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
