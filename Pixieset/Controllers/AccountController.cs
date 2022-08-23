using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Models;
using Pixieset.Utilities;
using Pixieset.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pixieset.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
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
                TermsAndContensions = register.TermsAndConditions



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
                await userManager.AddToRoleAsync(User, Roles.Member.ToString());
            }
            else
            {
                ModelState.AddModelError("", "Accept the terms or you will not be able to register");
                return View(register);
            }
           
            string Token = await userManager.GenerateEmailConfirmationTokenAsync(User);
            string Link = Url.Action(nameof(VerifyEmail), "Account", new {email=User.Email,Token},Request.Scheme,Request.Host.ToString());
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("vahidselimov22@gmail.com", "Pixiest Company");
            mailMessage.To.Add(new MailAddress(User.Email));
            mailMessage.Subject = "Verify Email"; 
            string body=string.Empty;
            
            using(StreamReader reader = new StreamReader("wwwroot/assets/template/verifyemail.html"))
            {
             body=reader.ReadToEnd();
            }
            string about = $"Hi <strong>{User.FirstName + " " + User.LastName}</strong> In order to start using your  account, you need to confirm your email address.";
            body  = body.Replace("{{link}}", Link);
            mailMessage.Body = body.Replace("{{About}}", about);
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp= new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("vahidselimov22@gmail.com", "xaubxzfdauzruupt");
            smtp.Send(mailMessage);
            TempData["Verify"] = true;
            await userManager.AddToRoleAsync(User, Roles.Member.ToString());

            
            return RedirectToAction("Products", "Home");
            

        }
        public async Task<IActionResult> VerifyEmail(string email,string token )
        {
            AppUser user = await userManager.FindByEmailAsync(email);
            if(user == null)
            {
                return BadRequest();
            }
            await userManager.ConfirmEmailAsync(user, token);
            await signInManager.SignInAsync(user, true);
            TempData["Verified"]=true;

            return RedirectToAction("Products","Home");

        }
        public IActionResult Login()
        {
            return View();

        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> ForgotPassword(AccountVM account)
        {
            AppUser user = await userManager.FindByEmailAsync(account.AppUser.Email);
            if (user == null)
            {
                return BadRequest();
            }
            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            string link = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("vahidselimov22@gmail.com", "Pixieset");
            mail.To.Add(new MailAddress(user.Email));
            mail.Subject = "Reset Password";
            //string body=string.Empty;
            //using(StreamReader reader = new StreamReader("wwwroot/assets/template/resedpassword.html"))
            //{
            //    body = reader.ReadToEnd();
            //}

            mail.Body = $"<a href='{link}'>Please click here to reset your Password</a>";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("vahidselimov22@gmail.com", "xaubxzfdauzruupt");

            smtp.Send(mail);
            return RedirectToAction("Products", "Home");

        }
        public async  Task<IActionResult> ResetPassword(string email,string token)
        {
            AppUser user= await userManager.FindByEmailAsync(email);
            if(user == null)
            {
                return BadRequest();
            }
            AccountVM model = new AccountVM
            {
                AppUser = user,
                Token = token
            };
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(AccountVM account)
        {
            AppUser user = await userManager.FindByEmailAsync(account.AppUser.Email);
            if (user == null)
            {
                return BadRequest();
            }
            AccountVM model = new AccountVM
            {
                AppUser = user,
                Token = account.Token
            };
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            await userManager.ResetPasswordAsync(user, account.Token, account.Password);
            await signInManager.SignInAsync(user, true);
           
            return RedirectToAction("Products", "Home");
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
            IList<string> roles = await userManager.GetRolesAsync(user);
            string role = roles.FirstOrDefault(r => r.ToLower().Trim() == Roles.Member.ToString().ToLower().Trim());
            if (role == null)
            {
                ModelState.AddModelError("", "Something went wrong.Please contact with admins");
                return View();

            }
            else
            {
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

        public async Task CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
            await roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
            await roleManager.CreateAsync(new IdentityRole { Name = Roles.SuperAdmin.ToString() });

        }
    }
}
