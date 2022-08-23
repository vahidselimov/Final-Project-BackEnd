using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("PixiesetAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
