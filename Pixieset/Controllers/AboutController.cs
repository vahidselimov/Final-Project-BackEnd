﻿using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }

    }
}
