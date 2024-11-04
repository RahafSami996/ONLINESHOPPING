using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace OnlineShoppingSystem.Controllers
{
    //[Authorize(Roles ="Admin")]
    //[Authorize(Roles = "Seller")]
    public class SellerAddressController:Controller
    {
  
        private readonly UserManager<User> userManager;
        private readonly ICommanServer commanServer;
        private readonly ISellerUserAddress AddressRepository;



        public SellerAddressController( ICommanServer commanServer,
            UserManager<User> userManager, ISellerUserAddress AddressRepository)
        {
            this.userManager = userManager;
            this.commanServer = commanServer;
            this.AddressRepository = AddressRepository;
        }
        [HttpGet]
        public IActionResult Selleradress()
        {

           
           var sellerId= ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            
            
            User user = userManager.FindByIdAsync(sellerId).Result;

            var ListAdress = AddressRepository.GetAllAddress(Convert.ToInt32(sellerId));

            return View(ListAdress);
        }

        [HttpPost]
        public IActionResult Selleradress(SellerAddressDTO model)
        {
            var sellerId = ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            var ListAdress = AddressRepository.GetAllAddress(Convert.ToInt32(sellerId));
            if (ModelState.IsValid)
            {
                try
                {
                    AddressRepository.InserSeller(model);
                    return RedirectToAction("Selleradress", ListAdress, sellerId);
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "the Addess already exist";
                    return View("Error");
                }
            }
            
            return RedirectToAction("Selleradress", ListAdress, sellerId);

        }

       public IActionResult EditSellerProfile(SellerAddressDTO obj)
        {
            var sellerId = ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            AddressRepository.UpdateSeller(obj);
            var ListAdress = AddressRepository.GetAllAddress(Convert.ToInt32(sellerId));
            return RedirectToAction("Selleradress", ListAdress, sellerId);

        }

        public JsonResult Country()
        {
            var country = commanServer.GetAllCountries();
            return Json(country);
        }

        public JsonResult Cities(int id)
        {
            List<City> Li_City = commanServer.GetAllCites(id);
            return Json(Li_City);
        }

        public IActionResult DeleteSellerAddress(int id)
        {
            AddressRepository.DeleteSeller(id);
            return RedirectToAction("Selleradress");
                
            }
        }
    }

