using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
