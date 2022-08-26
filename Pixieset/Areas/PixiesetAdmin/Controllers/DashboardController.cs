using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Utilities;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class DashboardController : Controller
    {
        [Area("PixiesetAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
