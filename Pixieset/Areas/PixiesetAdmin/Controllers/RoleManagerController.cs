using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pixieset.Models;
using System.Threading.Tasks;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{
    [Area("PixiesetAdmin")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class RoleManagerController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleManagerController(UserManager<AppUser>userManager,SignInManager<AppUser>signInManager,RoleManager<IdentityRole>roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        [Area("PixiesetAdmin")]
        public async Task<IActionResult> Index()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(roles);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName.Trim().ToLower()));
            }
            return RedirectToAction("Products","Home");
        }
    }
}
