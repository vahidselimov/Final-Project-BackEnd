using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Controllers
{
    public class Services : Controller
    {
        public IActionResult TermsofServices()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult DPA()
        {
            return View();
        }
        public IActionResult CookiePolicy()
        {
            return View();
        }
    }
}
