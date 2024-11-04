using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;


namespace OnlineShoppingSystem.Controllers
{
 
    public class LoginController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly OnlineShopingDbContext context;

        public LoginController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<ApplicationRole> roleManager, OnlineShopingDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }

        [HttpGet]
        public IActionResult Register()
        {
            var allRoles =context.Roles.OrderBy(r => r.Name).ToList().Select(rr =>

             new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
            var vsdd =context.Roles.OrderBy(r => r.Name).ToList();
            ViewBag.Roles = allRoles;
            return View();
            //var allRoles = roleManager.Roles.ToList();
            //return View(allRoles);
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.Phone,
                    PasswordHash = model.Password
                };
                var RoleName = model.UserRole;
                var result = await userManager.CreateAsync(user, model.Password);
                var Result = await userManager.AddToRoleAsync(user, RoleName);

                if (result.Succeeded)
                {

                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("SignIn");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto model)
        {

            ViewBag.UserId = userManager.GetUserId(HttpContext.User);

            if (ModelState.IsValid)
            {
                User signedUser = await userManager.FindByEmailAsync(model.Email);
                var result = await signInManager.PasswordSignInAsync(signedUser.UserName,
                    model.Password, model.RememberMe,false);
                
                if (result.Succeeded)
                {
                    //var userobj = userManager.Users.FirstOrDefault(a => a.UserName == model.UserName);

                    //HttpContext.Session.SetString("UserId", userobj.Id.ToString());
                    //HttpContext.Session.GetString("UserId");

                    return RedirectToAction("AllProduct", "Product",new { id = ViewBag.UserId });
                }
                
                    ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
                
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AcessDenid()
        {
            return View();
        }
    }
}