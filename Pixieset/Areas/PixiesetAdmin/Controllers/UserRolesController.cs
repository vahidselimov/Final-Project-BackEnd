﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pixieset.Models;
using System.Threading.Tasks;
using Pixieset.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Pixieset.DAL;
using Pixieset.Utilities;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{

    public class UserRolesController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext context;
        private readonly SignInManager<AppUser> signInManager;

        public UserRolesController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager,AppDbContext context,SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.context = context;
            this.signInManager = signInManager;
        }
        [Area("PixiesetAdmin")]
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var userRolesVM = new List<UserRolesVM>();
            foreach (AppUser user in users)
            {
                var thisViewModel = new UserRolesVM();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesVM.Add(thisViewModel);

            }

            return View(userRolesVM);

        }
       

        [Area("PixiesetAdmin")]
        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.userId = userId;
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }
            ViewBag.userName = user.UserName;
            var model = new List<ManageUserRole>();
            foreach (var role in roleManager.Roles.ToList())
            {
                var userRolesVM = new ManageUserRole
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                  
                };
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesVM.Selected = true;
                   
               
                }
                else
                {
                    userRolesVM.Selected = false;
                }
                model.Add(userRolesVM);



                
                
                  
                    await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
                
             


            }
            return View(model);
        }


        [HttpPost]
       
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Manage(List<ManageUserRole> model, string userId)
        {
            
            var user = await userManager.FindByIdAsync(userId);
         
            if (user == null)
            {
                return RedirectToAction("Profile","Profiles");
            }
           
            var roles = await userManager.GetRolesAsync(user);
           
            await userManager.UpdateAsync(user);
            var result = await userManager.RemoveFromRolesAsync(user, roles.ToList());
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            result = await userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            await userManager.UpdateAsync(user);
            
            
            return RedirectToAction("Index","DashBoard");
        }
        
       
        private async Task<List<string>> GetUserRoles(AppUser user)
        {

            return new List<string>(await userManager.GetRolesAsync(user));
        }

    }
}