﻿using Microsoft.AspNetCore.Mvc;

namespace iremPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
