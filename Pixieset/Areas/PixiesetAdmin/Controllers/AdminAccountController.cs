using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Areas.PixiesetAdmin.ViewModels;
using Pixieset.DAL;
using Pixieset.Models;
using Pixieset.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{
    
    [Area("PixiesetAdmin")]

    public class AdminAccountController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AdminAccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        //public async Task<IActionResult> IsBlock(string id)
        //{
        //    if (!ModelState.IsValid) return View();
        //    AppUser existedUser = await context.AppUser.FirstOrDefault(s => s.Id == id);
        //    if (existedUser == null) return NotFound();
        //    if (existedUser.IsBlock == false)
        //    {
        //        existedUser.IsBlock = true;
        //        await signInManager.SignOutAsync();
        //    }
        //    else if (existedUser.IsBlock == true)
        //    {
        //        existedUser.IsBlock = false;
        //        await signInManager.SignInAsync(existedUser, false);
        //    }
        //    await context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //[Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Edit(string id)
        {
            AppUser user = await context.AppUsers.FindAsync(id);
            return View(user);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(AppUser user)
        {
            if (!ModelState.IsValid) return View();

            AppUser existerUser = await context.AppUsers.FirstOrDefaultAsync(s => s.Id == user.Id);
            if (existerUser == null) return NotFound();

            existerUser.FirstName = user.FirstName;
            existerUser.LastName = user.LastName;

            if (user.IsBlock==true)
            {
                existerUser.IsBlock = false;
            }
            else if (user.IsBlock==false)
            {
                existerUser.IsBlock=true;
            }


            if (user.IsAdmin==true)
            {
                existerUser.IsAdmin = false;
            }
            else if (user.IsAdmin==false)
            {
                existerUser.IsAdmin=true;
            }
            existerUser.IsAdmin=user.IsAdmin;
            existerUser.IsBlock = user.IsBlock;
            await context.SaveChangesAsync();
            return RedirectToAction("Dashboard");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(AdminLoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await userManager.FindByNameAsync(loginVM.Username);
            if (user == null) return View("Error");
            IList<string> roles = await userManager.GetRolesAsync(user);
            string adminRole = roles.FirstOrDefault(r => r.Trim().ToLower() == Roles.Admin.ToString().ToLower().Trim());
            string superAdminRole = roles.FirstOrDefault(r => r.Trim().ToLower() == Roles.SuperAdmin.ToString().ToLower().Trim());
            if (adminRole == null && superAdminRole == null)
            {
                ModelState.AddModelError("", "Something went wrong. Please try again");
                return View();
            }
            else
            {
                if (loginVM.RememberMe)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginVM.Password, true, true);

                    if (!result.Succeeded)
                    {
                        if (result.IsLockedOut)
                        {
                            ModelState.AddModelError("", "You have been dismissed for 5 minutes");
                            return View();
                        }
                        ModelState.AddModelError("", "Username or Password is incorrect");
                        return View();
                    }
                }
                else
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginVM.Password, false, true);
                    if (!result.Succeeded)
                    {
                        if (result.IsLockedOut)
                        {
                            ModelState.AddModelError("", "You have been dismissed for 5 minutes");
                            return View();
                        }
                        ModelState.AddModelError("", "Username or Password is incorrect");
                        return View();
                    }
                }
                return RedirectToAction("Index", "Dashboard");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

       

        public async Task<IActionResult> CreateAdmin()
        {
            AppUser appUser = new AppUser
            {
                Email = "vahidselimov12@gmail.com",
                UserName = "SuperAdmin",
                FirstName = "Admin",
                LastName = "Super",
                PhoneNumber = "0509621210",
                EmailConfirmed = true,
                IsAdmin=true,
                TermsAndContensions=true
               
            };
            await userManager.CreateAsync(appUser, "Vahid1-1");
            await userManager.AddToRoleAsync(appUser, Roles.SuperAdmin.ToString());
            return Content("Super Admin Was Successfully Created");
        }
    }
}
