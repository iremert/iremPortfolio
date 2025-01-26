using Microsoft.AspNetCore.Mvc;

namespace iremPortfolio.ViewComponents
{
    public class _AboutComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
