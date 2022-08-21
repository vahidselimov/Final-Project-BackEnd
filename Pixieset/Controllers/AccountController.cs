using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Models;
using Pixieset.ViewModels;
using System.Threading.Tasks;

namespace Pixieset.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser User = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.UserName,
                TermsAndContensions=register.TermsAndConditions



            };

            if (register.TermsAndConditions)
            {
                Microsoft.AspNetCore.Identity.IdentityResult result = await userManager.CreateAsync(User, register.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Accept the terms or you will not be able to register");
                return View(register);
            }

            await signInManager.SignInAsync(User, false);
            return RedirectToAction("Products", "Home");

        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            AppUser user = await userManager.FindByNameAsync(loginVM.UserName);

            if (user == null)
            {
                return View();

            }
            if (!loginVM.RememberMe)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginVM.Password, true, true);
                if (!result.Succeeded)
                {
                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError("", "You have been dismissed for 5 miniutes");
                    }

                    ModelState.AddModelError("", "UserName or Password is in incorrect");
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
                        ModelState.AddModelError("", "You have been dismissed for 5 miniutes");
                    }

                    ModelState.AddModelError("", "UserName or Password is in incorrect");
                    return View();


                }
            }

            return RedirectToAction("Profiles", "Profile");
        }
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            return RedirectToAction("Products", "Home");
        }
        public IActionResult Show()
        {
            return Content(User.Identity.IsAuthenticated.ToString());

        }
        public async Task<IActionResult> Settings()
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            SettingsVM settings = new SettingsVM();

            settings.UserName = user.UserName;
            settings.LastName = user.LastName;
            settings.Email = user.Email;



            return View(settings);

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Settings(SettingsVM vM)
        {
            AppUser Existeduser = await userManager.FindByNameAsync(User.Identity.Name);
            SettingsVM settingsVM = new SettingsVM
            {
                UserName = Existeduser.UserName,
                LastName = Existeduser.LastName,
                Email = Existeduser.Email,

            };
            if (!ModelState.IsValid)
            {
                return View(settingsVM);
            }
            bool result = vM.Password == null && vM.ConfirmPassword == null && vM.CurrentPassword != null;
            if (vM.Email == null || vM.Email != Existeduser.Email)
            {
                ModelState.AddModelError("", "You can not change your email");
                return View(settingsVM);
            }
            if (result)
            {
                Existeduser.UserName = vM.UserName;
                Existeduser.LastName = vM.LastName;
                Existeduser.Email = vM.Email;
                Existeduser.PasswordHash = vM.Password;

                await userManager.UpdateAsync(Existeduser);

            }
            else
            {
                Existeduser.UserName = vM.UserName;
                Existeduser.LastName = vM.LastName;
                Existeduser.Email = vM.Email;
                if (vM.CurrentPassword == vM.Password)
                {
                    ModelState.AddModelError("", "You can not change password with the same password");
                    return View();
                }
                IdentityResult ResultSettings = await userManager.ChangePasswordAsync(Existeduser, vM.CurrentPassword, vM.Password);
                if (!ResultSettings.Succeeded)
                {
                    foreach (IdentityError error in ResultSettings.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(settingsVM);
                }

            }

            return RedirectToAction("Profiles", "Profile");





        }
    }
}
