using Microsoft.AspNetCore.Mvc;

namespace iremPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
