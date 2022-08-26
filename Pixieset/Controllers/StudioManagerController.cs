using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Controllers
{
    public class StudioManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
