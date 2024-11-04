using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace OnlineShoppingSystem.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly OnlineShopingDbContext context;

        public AdministrationController(RoleManager<ApplicationRole> roleManager,
          UserManager<User> userManager,OnlineShopingDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context = context;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleDTO model)
        {
            if (ModelState.IsValid)
            {
                ApplicationRole identityRole = new ApplicationRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult ListUser()
        {
            IQueryable<User> users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        public IActionResult ListRole()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(int id)
        {
            //var user = await userManager.Users.Where(x => x.Id == id).SingleOrDefault();
            var user = await userManager.FindByIdAsync(id.ToString());

            var allRoles = context.Roles.OrderBy(r => r.Name).ToList().Select(rr =>

              new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
            var vsdd = context.Roles.OrderBy(r => r.Name).ToList();
            ViewBag.Roles = allRoles;
            

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={id} cannot be found";
                return View("NotFound");
            }
            var UserRoles = await userManager.GetRolesAsync(user);
            var model = new EditUserDTO
            {
                Id =Convert.ToInt32( user.Id),
                UserName = user.UserName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Password=user.PasswordHash,
                Roles =UserRoles


            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> EditUser(UserDTO model, int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var role = await roleManager.FindByIdAsync(id.ToString());

            var userid = userManager.GetUserId(HttpContext.User);

            var allRoles = context.Roles.OrderBy(r => r.Name).ToList().Select(rr =>

             new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
            var vsdd = context.Roles.OrderBy(r => r.Name).ToList();
            ViewBag.Roles = allRoles;

            if (ModelState.IsValid)
            {
                var UserRoles = await userManager.GetRolesAsync(user);

                User obj = new User
                {
                    Id = Convert.ToInt32(userid),
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.Phone,
                    Password = model.Password,
                    //RoleUsers = UserRoles

                };
                await userManager.UpdateAsync(obj);
                var obj2 = new List<UserRoleDTO>();
                    var userRoleDTO = new UserRoleDTO
                    {
                        UserId = Convert.ToInt32(user.Id),
                        UserName = user.UserName
                    };
                   
                    obj2.Add(userRoleDTO);
                
                return View(model);
            }
            return RedirectToAction("ListUser");
        }
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id ={id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUser");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListUser");
            }
        }


        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = await roleManager.FindByIdAsync(id.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"User with Id ={id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListRole");
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(int id)
        {
            var role = await roleManager.FindByIdAsync(id.ToString());
            //var role = Role.GetByid(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleDTO
            {
                Id =Convert.ToInt32(role.Id),
                RoleName = role.Name
            };
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleDTO model)
        {
            var role = await roleManager.FindByIdAsync(model.Id.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListRole");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(int roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleDTO>();
            foreach(var user in userManager.Users)
            {
                var userRoleDTO = new UserRoleDTO
                {
                    UserId=Convert.ToInt32( user.Id),
                    UserName=user.UserName
                };
                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleDTO.IsSelected = true;
                }
                else
                {
                    userRoleDTO.IsSelected = false;
                }
                model.Add(userRoleDTO);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleDTO> model,int roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id={roleId} cannot be found";
                return View("NotFound");
            }
         for(int i=0; i<model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId.ToString());

                IdentityResult result = null;
                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user,role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);

                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });

        }

       
        //[HttpGet]
        //public async Task<IActionResult> EditProfileSeeler(string id)
        //{
        //    var user = await userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        ViewBag.ErrorMessage = $"User with Id={id} cannot be found";
        //        return View("NotFound");
        //    }
        //    //var image = new ImageDTO();
        //    var address = new UserAdress();
        //    var model = new EditProfileSellerDTO
        //    {
        //         Id= user.Id,
        //        UserName = user.UserName,
        //        Email = user.Email,
        //        phone = user.PhoneNumber,
        //        Password = user.PasswordHash,
        //       //Image= image.Name,
        //       //Address=address.CityId,



        //    };

        //    return View(model);

        //}


    }

}
