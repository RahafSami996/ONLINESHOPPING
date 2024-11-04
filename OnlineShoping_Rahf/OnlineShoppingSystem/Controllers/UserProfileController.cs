using System;
using System.IO;
using System.Threading.Tasks;
using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingSystem.Models;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShoppingSystem.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ICommanServer commanServer;
        private readonly ISellerUserAddress AddressRepository;
        private readonly ICardPayment CardRepository;




        public UserProfileController(UserManager<User> userManager, ICommanServer commanServer,
            IHostingEnvironment hostingEnvironment, ISellerUserAddress AddressRepository,
            ICardPayment CardRepository)
        {
            this.userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
            this.commanServer = commanServer;
            this.AddressRepository = AddressRepository;
            this.CardRepository = CardRepository;

        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult UserProfile()
        {

            var userid = userManager.GetUserId(HttpContext.User);
            var Image = commanServer.GetImage(Convert.ToInt32(userid));
            User user = userManager.FindByIdAsync(userid).Result;
            var card = CardRepository.GetCard(Convert.ToInt32(userid));


            if (Image != null)
            {
                EditProfileSellerDTO editProfile = new EditProfileSellerDTO
                {
                    Id = Convert.ToInt32(user.Id),
                    UserName = user.UserName,
                    Image = Image.Data,
                    Password = user.PasswordHash,
                    Email = user.Email,
                    phone = user.PhoneNumber,
                    CardPayment=card
                    
                };
                return View(editProfile);
            }
            else
            {
                EditProfileSellerDTO editProfile = new EditProfileSellerDTO
                {
                    Id = Convert.ToInt32(user.Id),
                    UserName = user.UserName,
                    //Image = Image.Data,
                    Password = user.PasswordHash,
                    Email = user.Email,
                    phone = user.PhoneNumber,
                    CardPayment = card
                };
                return View(editProfile);
            }

        }

        [HttpGet]
        public IActionResult Useraddress()
        {


            var UserId = ViewBag.UserId = userManager.GetUserId(HttpContext.User);


            User user = userManager.FindByIdAsync(UserId).Result;

            var ListAdress = AddressRepository.GetAllAddressUser(Convert.ToInt32(UserId));


            EditProfileSellerDTO UserAddressd = new EditProfileSellerDTO
            {

                ListOfAddress = ListAdress
            };



            return View(UserAddressd);
        }

        [HttpPost]
        public IActionResult Useraddress(EditProfileSellerDTO model)
        {
            var UserId = ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            AddressRepository.InserUser(model);
            var ListAdress = AddressRepository.GetAllAddressUser(Convert.ToInt32(UserId));
            EditProfileSellerDTO UserAddressd = new EditProfileSellerDTO
                {
                    ListOfAddress = ListAdress
                };
                return RedirectToAction("EditProfileUser",new { id=UserId});
           
        }
        [HttpGet]
        public async Task<IActionResult> EditProfileUser(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var ListAdress = AddressRepository.GetAllAddressUser(Convert.ToInt32(id));



            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={id} cannot be found";
                return View("NotFound");
            }


            var model = new EditProfileSellerDTO
            {
                Id = Convert.ToInt32(user.Id),
                UserName = user.UserName,
                Email = user.Email,
                phone = user.PhoneNumber,
                Password = user.PasswordHash,
                ListOfAddress=ListAdress
                //Image=user.

            };
          
            return View(model);
        }
        public IActionResult EditAddressUser(EditProfileSellerDTO obj)
        {
            var userId = ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            AddressRepository.UpdateUserAddress(obj);
            var ListAdress = AddressRepository.GetAllAddressUser(Convert.ToInt32(userId));
            return RedirectToAction("EditProfileUser", ListAdress, userId);

        }
        [HttpPost]
        public IActionResult EditProfileUser(EditProfileSellerDTO model, IFormFile Image)
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
                    UserId = Convert.ToInt32(userid)

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
            return RedirectToAction("EditProfileUser", new { userid });

        }

        public IActionResult DeleteUserAddress(int id)
        {
            var userid = userManager.GetUserId(HttpContext.User);
            AddressRepository.DeleteUserAddress(id);
            return RedirectToAction("EditProfileUser",new { id=userid});

        }

        [HttpGet]
        public IActionResult PaymentCart(int Id)
        {

            var userid = userManager.GetUserId(HttpContext.User);
            PaymentCardDTO Card = new PaymentCardDTO
            {
                ListStatus = CardRepository.GetAllstatus()
            };

            return View(Card);
           

        }

        [HttpPost]
        public IActionResult PaymentCart(PaymentCardDTO model)
        {
            var userid = userManager.GetUserId(HttpContext.User);
            CardRepository.InserCard(model);
            return RedirectToAction("UserProfile");
            }

        [HttpGet]
        public IActionResult EditCardPayment(int Id)
        {

            var userid = userManager.GetUserId(HttpContext.User);
            var AllCard = CardRepository.GetCards(Convert.ToInt32( userid));
            return View(AllCard);


        }

        [HttpPost]
        public IActionResult EditCardPayment(PaymentCardDTO model)
        {
            var userid = userManager.GetUserId(HttpContext.User);
            if (ModelState.IsValid)
            {
                CardRepository.UpdateCard(model);
            }
            return RedirectToAction("UserProfile");
        }

        public IActionResult DeleteCard(int Id)
        {
            CardRepository.DeleteCard(Id);
            return RedirectToAction("UserProfile");
            
        }

    }
}
