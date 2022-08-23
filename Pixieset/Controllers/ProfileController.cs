using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pixieset.Controllers
{
    
    public class ProfileController : Controller
    {
        public IActionResult Profiles()
        {
            return View();
        }

    }
}
