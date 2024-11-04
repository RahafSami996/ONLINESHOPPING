using System;
using System.Collections.Generic;
using System.IO;
using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingSystem.Models;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace OnlineShoppingSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IProductRepository productRepository ;
        private readonly ICommanServer commanServer;
        private readonly IColorSize ColorSizeRepository;
        private readonly ISeasonType SeasonTypeReposirory;

        private readonly HostingEnvironment hostingEnvironment;

        public ProductController(UserManager<User> userManager,IProductRepository productRepository,
             ICommanServer commanServer,HostingEnvironment hostingEnvironment,
             IColorSize ColorSizeRepository, ISeasonType SeasonTypeReposirory)
        {
            this.userManager = userManager;
            this.productRepository = productRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.commanServer = commanServer;
            this.ColorSizeRepository = ColorSizeRepository;
            this.SeasonTypeReposirory = SeasonTypeReposirory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var AllColor = ColorSizeRepository.GetAllColors();
            ViewBag.Allcolr = AllColor;

            var AllSize = ColorSizeRepository.GetAllsize();
            ViewBag.AllSize = AllSize;
            //var Quantity = productRepository.GetProduct(id);
            ProductDTO product = new ProductDTO
            {
                ListSeasons = SeasonTypeReposirory.GetAllSeasons(),
                ListTypeOfLeathers = SeasonTypeReposirory.GetAllType(),
                ListColor = ColorSizeRepository.GetAllColors(),
                ListSize = ColorSizeRepository.GetAllsize(),
                //ListSizesColor = ColorSizeRepository.GetAllProductSize(model.ProductId)
            };
            
            return View(product);
        }

        //[HttpPost]
        //public IActionResult CreateProduct(ProductDTO model,  List<ColorSizeDTO> ListColorSize,  IFormFile Image)
        //{
        //    //HttpContext.Session.GetString("UserId");
        //    productRepository.Insert(model, Image,ListColorSize);
           
        //    ProductDTO product = new ProductDTO
        //        {                   
        //            ListSeasons = SeasonTypeReposirory.GetAllSeasons(),
        //            ListTypeOfLeathers = SeasonTypeReposirory.GetAllType(),
        //            ListColor = ColorSizeRepository.GetAllColors(),
        //            ListSize = ColorSizeRepository.GetAllsize(),
        //    };
        //        return View("CreateProduct", product);

            
        //}



        [HttpPost]
        public IActionResult CreateProduct(ProductDTO model)
        {
            productRepository.Insert(model);
            ProductDTO product = new ProductDTO
            {
                ListSeasons = SeasonTypeReposirory.GetAllSeasons(),
                ListTypeOfLeathers = SeasonTypeReposirory.GetAllType(),
                ListColor = ColorSizeRepository.GetAllColors(),
                ListSize = ColorSizeRepository.GetAllsize(),
            };
            return View("CreateProduct", product);

            
            
        }

        //[HttpGet]
        //public IActionResult ColorSizeProduct(int id)
        //{

        //   var AllColor = ColorSizeRepository.GetAllColors();
        //    ViewBag.Allcolr = AllColor;

        //    var AllSize = ColorSizeRepository.GetAllsize();
        //    ViewBag.AllSize = AllSize;
        //    var Quantity = productRepository.GetProduct(id);

        //    var AllProduct = ColorSizeRepository.GetAllProductSize(id);
        //    ProductDTO colorSize = new ProductDTO
        //    {
        //        ListColor = AllColor,
        //        ListSize=AllSize,
        //        ListColorSize=AllProduct,
        //        QuantityProduct=Quantity.Quantity

        //    };
        //    return View(colorSize);
        //}

        //[HttpPost]
        //public IActionResult ColorSizeProduct(ProductDTO model)
        //{


        //    if (ModelState.IsValid)
        //    {
        //        ProductColorSize obj = new ProductColorSize
        //        {
        //            Quentity = model.QuantityColor,
        //            ColorId = model.Color,
        //            SizeId = model.Size,
        //            ProductId = model.ProductId
        //        };
        //        ColorSizeRepository.InsertColorSize(obj);
        //        ProductDTO colorSize = new ProductDTO
        //        {
        //            ListColor = ColorSizeRepository.GetAllColors(),
        //            ListSize = ColorSizeRepository.GetAllsize(),
        //            ListColorSize = ColorSizeRepository.GetAllProductSize(model.ProductId)

        //        };
        //        return RedirectToAction("CreateProduct", colorSize);
        //    }
        //    return View();
        //}

        public IActionResult DeleteColorSize(int id,int ProductId)
        {

            ColorSizeRepository.DeleteSizeColor(id);

            var AllColor = ColorSizeRepository.GetAllColors();
            ViewBag.Allcolr = AllColor;

            var AllSize = ColorSizeRepository.GetAllsize();
            ViewBag.AllSize = AllSize;

            var AllProduct = ColorSizeRepository.GetAllProductSize(ProductId);
            return RedirectToAction("ColorSizeProduct", new { id = ProductId });

        }

        [HttpGet]
        public IActionResult ListProduct()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var prodect = productRepository.GetAllProdectList(Convert.ToInt32( userid));
           
            ProductDTO model = new ProductDTO
            {
              
               Listproduct = prodect,
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult EditProduct(int Id)
        {
            var ListSeasons = SeasonTypeReposirory.GetAllSeasons();
            var ListTypeOfLeathers = SeasonTypeReposirory.GetAllType();

            var AllProduct = productRepository.GetProductByid(Id);
            var Image = commanServer.GetImages(Id);
            ProductDTO obj = new ProductDTO
            {
               ListSeasons=ListSeasons,
               ListTypeOfLeathers=ListTypeOfLeathers,
                ProductId = AllProduct.ProductId,
                ProductName = AllProduct.ProductName,
                Quantity = AllProduct.Quantity,
                Price = AllProduct.Price,
                Code = AllProduct.Code,
                SeasonId = AllProduct.SeasonId,
                TypeId = AllProduct.TypeId,
                image =Image.Name   

            };

            return View(obj);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductDTO model, int Id)
        {
            //commanServer.DeleteImage(Id);
            //var userid = userManager.GetUserId(HttpContext.User);
            //if (ModelState.IsValid)
            //{
             
            //    //var image = imagerepository.GetImages(Id);
            //    var image = model.image;
            //    Products prodect = new Products
            //    {
            //        Id=model.ProductId,
            //        Name = model.ProductName,
            //        Quantity = model.Quantity,
            //        Price=model.Price,
            //        Code = model.Code,
            //        TypeId = model.TypeId,
            //        SeasonId = model.SeasonId,
            //        SellerID =Convert.ToInt32( userid)

            //    };

                productRepository.Update(model);
                //if (image != null)
                //{
                //    Image obj = new Image
                //    {
                //        //Id= image.Id,
                //        Name = image,
                //        ProductId = prodect.Id,
                //        UserId = Convert.ToInt32(userid)

                //    };
                //    //ViewBag.Photo = uniqueFileName;
                //    commanServer.InsertImage(obj);
                //}
                ProductDTO product = new ProductDTO
                {

                    ListSeasons = SeasonTypeReposirory.GetAllSeasons(),
                    ListTypeOfLeathers = SeasonTypeReposirory.GetAllType(),
                    ListSizesColor=ColorSizeRepository.GetAllProductSize(model.ProductId)

                };
              
                return RedirectToAction("EditProduct");

            }
           

        public ActionResult DeleteProdect(int id)
        {
            commanServer.DeleteImage(id);
            productRepository.Delete(id);
            
            return RedirectToAction("ListProduct");
        }

        [HttpGet]
        public IActionResult AllProduct()
        {
           var AllProduct= productRepository.GetAllProduct();
            ProductDTO product = new ProductDTO
            {
                Listproduct=AllProduct,
               
            };
            return View(product);
        }

        [HttpGet]
      public PartialViewResult popupModal(int id)
        {
            var SizeType = productRepository.GetProducts(id);
            var AllProduct = productRepository.GetAllProduct(id);
            var ListSeasons = SeasonTypeReposirory.GetAllSeasons();
            var ListTypeOfLeathers = SeasonTypeReposirory.GetAllType();
            ProductDTO obj = new ProductDTO
            {
                ProductName = SizeType.Name,
                Price = SizeType.Price,
                Quantity = SizeType.Quantity,
                Seasons = SizeType.Season.Name,
                Type = SizeType.TypeOfLeather.TypeName,
               Listproduct=AllProduct
            };
            ViewBag.Product = obj;
            return PartialView();
        }
       

        [HttpPost]
        public IActionResult AllProduct(int Id)
        {
            var userid = userManager.GetUserId(HttpContext.User);
          
                productRepository.InsertToCart(Id);
                return RedirectToAction("CartProduct");
        }

        [HttpGet]
        public IActionResult CartProduct()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var product = productRepository.GetAllCartProduct(Convert.ToInt32(userid));
            return View(product);
        }

        public IActionResult DeleteCart(int id)
        {
            productRepository.DeleteCart(id);
            return RedirectToAction("CartProduct");
        }

        public IActionResult EditColorSize(ColorSizeDTO obj)
        {
           
            ColorSizeRepository.Update(obj);
            var ListColorSize = ColorSizeRepository.GetAllProductSizes(obj.ProductId);
            return RedirectToAction("EditProduct", ListColorSize);

        }

    }
}