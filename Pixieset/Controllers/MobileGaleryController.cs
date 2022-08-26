using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Controllers
{
    public class MobileGaleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
