using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
