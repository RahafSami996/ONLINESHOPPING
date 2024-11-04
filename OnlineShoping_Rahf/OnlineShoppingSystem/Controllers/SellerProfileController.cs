using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingSystem.Models;
using static Microsoft.IdentityModel.Tokens.Saml2.Saml2Constants;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShoppingSystem.Controllers
{
    public class SellerProfileController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ICommanServer commanServer;


        public SellerProfileController(UserManager<User> userManager, ICommanServer commanServer,
            IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
            this.commanServer = commanServer;
           
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult ListProfileSeller()
        {
            
            var userid = userManager.GetUserId(HttpContext.User);
            var Image = commanServer.GetImage(Convert.ToInt32( userid));
            User user = userManager.FindByIdAsync(userid).Result;
            //var users = userManager.Users;
            if(Image !=null)
            {
                EditProfileSellerDTO editProfile = new EditProfileSellerDTO
                {
                    Id =Convert.ToInt32( user.Id),
                    UserName = user.UserName,
                    Image = Image.Data,
                    Password = user.PasswordHash,
                    Email = user.Email,
                    phone = user.PhoneNumber
                };
                return View(editProfile);
            }
            else
            {
                EditProfileSellerDTO editProfile = new EditProfileSellerDTO
                {
                    Id =Convert.ToInt32( user.Id),
                    UserName = user.UserName,
                    //Image = Image.Data,
                    Password = user.PasswordHash,
                    Email = user.Email,
                    phone = user.PhoneNumber
                };
                return View(editProfile);
            }
           
        }

        [HttpGet]
        public async Task<IActionResult> EditProfileSeeler(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());



            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={id} cannot be found";
                return View("NotFound");
            }


            var model = new EditProfileSellerDTO
            {
                Id =Convert.ToInt32( user.Id),
                UserName = user.UserName,
                Email = user.Email,
                phone = user.PhoneNumber,
                Password = user.PasswordHash,
                //Image=user.

            };

            return View(model);

        }
        [HttpPost]
        public IActionResult EditProfileSeeler(EditProfileSellerDTO model, IFormFile Image)
        {
            var userid = userManager.GetUserId(HttpContext.User);
            if (Image != null)
            {
                byte[] imageBytes = null;
                BinaryReader reader = new BinaryReader(Image.OpenReadStream());
                imageBytes = reader.ReadBytes((int)Image.Length);
                Image image = new Image
                {
                    Name = Image.Name,
                    ContentType = Image.ContentType,
                    Data = imageBytes,
                    UserId =Convert.ToInt32( userid)

                };
                commanServer.InsertImage(image);
            }

               

            User obj = new User()
            {
                UserName = model.UserName,
                PhoneNumber = model.phone,
                PasswordHash = model.Password,
                Email = model.Email,
            };
            userManager.UpdateAsync(obj);
            return RedirectToAction("ListProfileSeller", new { id = obj.Id });
            
        }
            
       

    }
}
