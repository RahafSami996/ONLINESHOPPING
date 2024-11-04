using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.SpecificRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IGenaricRepository<Products> productGenaricRepository;
        private readonly IGenaricRepository<Color> GenaricColor;
        private readonly IGenaricRepository<Size> GenaricSize;
        private readonly IGenaricRepository<ProductColorSize> GenaricSizeColor;
        private readonly IGenaricRepository<Cart> Genariccart;
        private readonly UserManager<User> userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IGenaricRepository<Image> GenaricImage;



        public ProductRepository(GenaricRepostory<Products> _productGenaricRepository,
            UserManager<User> _userManager,
            GenaricRepostory<Color> _GenaricColor,
            GenaricRepostory<Size> _GenaricSize,
            GenaricRepostory<ProductColorSize> _GenaricSizeColor,
            GenaricRepostory<Cart> _Genariccart,
            IHttpContextAccessor httpContextAccessor,
            GenaricRepostory<Image> _GenaricImage)
        {
            productGenaricRepository = _productGenaricRepository;
            GenaricColor = _GenaricColor;
            GenaricSize = _GenaricSize;
            GenaricSizeColor = _GenaricSizeColor;
            Genariccart = _Genariccart;
            _httpContextAccessor = httpContextAccessor;
            userManager = _userManager;
            GenaricImage = _GenaricImage;
        }

        public void Delete(int id)
        {
            productGenaricRepository.Delete(id);
            productGenaricRepository.Save();
        }
        public void DeleteSizeColor(int id)
        {
            GenaricSizeColor.Delete(id);
            GenaricSizeColor.Save();
        }

        public List<Color> GetAllColors()
        {
            return GenaricColor.GetAll();
        }

        public List<Products> GetAllProduct()
        {
            return productGenaricRepository.GetAlls()
                .Include(x => x.ListOfImage)
                .Include(x => x.ProductColorSizes).ToList();
        }
        public List<Products> GetAllProducts(int id)
        {
            return productGenaricRepository.GetAlls()
                .Include(x => x.ListOfImage)
                .Include(x => x.ProductColorSizes)
                .Where(x => x.Id == id).ToList();
        }

        public List<ProductColorSize> GetAllProductSize(int id)
        {
            var AllProduct = GenaricSizeColor.GetAlls()
                .Include(a => a.Color)
                .Include(a => a.Size).
               Where(a => a.ProductId == id).ToList();

            return AllProduct;
        }

        public List<Size> GetAllsize()
        {
            return GenaricSize.GetAll();
        }

        public Products GetProduct(int id)
        {
            return productGenaricRepository.GetById(id);
        }

        public ProductDTO GetProductByid(int id)
        {
            var product = productGenaricRepository.GetAlls().Include(a => a.ListOfImage).SingleOrDefault(a => a.Id == id);
            ProductDTO obj = new ProductDTO
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                Code = product.Code,
                SeasonId = product.SeasonId,
                TypeId = product.TypeId,

            };
            return obj;
        }

        public Products GetProducts(int id)
        {
            var product = productGenaricRepository.GetAlls()
                .Include(x => x.TypeOfLeather)
                .Include(x => x.Season)
                .SingleOrDefault(a => a.Id == id);
            return product;
        }

        public List<Products> GetAllProduct(int id)
        {
            var AllProduct = productGenaricRepository.GetAlls()
                .Include(x => x.Season)
                .Include(x => x.TypeOfLeather).
                Where(a => a.Id == id).ToList();
            return AllProduct;
        }

        public void Insert(ProductDTO obj)
        {

            var userid = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //string userid = HttpContext.Session.GetString("UserId");

            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(obj.logoFile.OpenReadStream());
            imageBytes = reader.ReadBytes((int)obj.logoFile.Length);

            List<Image> images = new List<Image>();

            images.Add(new Image
            {
                Name = obj.logoFile.Name,
                ContentType = obj.logoFile.ContentType,
                Data = imageBytes,
                UserId = Convert.ToInt32(userid)

            });

            List<ProductColorSize> items = new List<ProductColorSize>();
            foreach (var item in obj.ListColorSize)
            {
               
                    items.Add(new ProductColorSize
                    {
                        ColorId = item.Color,
                        SizeId = item.Size,
                        Quentity = item.Quantity,

                    });
               

               
               

            }
            Products prodect = new Products
            {
                Name = obj.ProductName,
                Quantity = obj.Quantity,
                Price = obj.Price,
                Code = obj.Code,
                TypeId = obj.TypeId,
                SeasonId = obj.SeasonId,
                SellerID = Convert.ToInt32(userid),
                ListOfImage = images,
                ProductColorSizes = items

            };


            productGenaricRepository.Insert(prodect);
            productGenaricRepository.Save();

        }

        public void InsertToCart(int Id)
        {
            var userid = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            Cart obj = new Cart
            {
                ProductID = Id,
                UserId = Convert.ToInt32(userid)
            };
            Genariccart.Insert(obj);
            Genariccart.Save();
        }

        public void InsertColorSize(ProductColorSize obj)
        {
            GenaricSizeColor.Insert(obj);
            GenaricSizeColor.Save();
        }

        public void Update(ProductDTO obj)
        {
            var userid = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //string userid = HttpContext.Session.GetString("UserId");

            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(obj.logoFile.OpenReadStream());
            imageBytes = reader.ReadBytes((int)obj.logoFile.Length);

            List<Image> images = new List<Image>();

            images.Add(new Image
            {
                Name = obj.logoFile.Name,
                ContentType = obj.logoFile.ContentType,
                Data = imageBytes,
                UserId = Convert.ToInt32(userid)

            });


            Products prodect = new Products
            {
                Name = obj.ProductName,
                Quantity = obj.Quantity,
                Price = obj.Price,
                Code = obj.Code,
                TypeId = obj.TypeId,
                SeasonId = obj.SeasonId,
                SellerID = Convert.ToInt32(userid),
                ListOfImage = images
            };


            productGenaricRepository.Update(prodect);
            productGenaricRepository.Save();
        }

        public List<Products> GetAllProdectList(int id)
        {
            var Product = productGenaricRepository.GetAlls()
                .Include(x => x.Season)
                .Include(x => x.ListOfImage)
                .Include(x => x.TypeOfLeather)
                .Where(a => a.SellerID == id).ToList();
            return Product;
        }

        public List<CartDTO> GetAllCartProduct(int id)
        {
            var Product = Genariccart.GetAlls().Include(x => x.Products).ThenInclude(x => x.ListOfImage)
                .Where(x => x.UserId == id).ToList();
            List<CartDTO> items = new List<CartDTO>();
            foreach (var item in Product)
            {
                items.Add(new CartDTO
                {
                    Id = item.Id,
                    ProductId = item.Products.Id,
                    ProductName = item.Products.Name,
                    Price = item.Products.Price,
                    Images = item.Products.ListOfImage

                });


            }
            return items;


        }


        public void DeleteCart(int id)
        {
            Genariccart.Delete(id);
            Genariccart.Save();
        }

        public ColorSizeDTO Repet(ColorSizeDTO obj)
        {
            var userid = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ColorSize = GenaricSizeColor.GetAlls()
                .Where(x => x.Quentity == obj.Quantity &&
                x.ColorId == obj.Color && x.SizeId == obj.Size)
                .FirstOrDefault();

            if (ColorSize == null)
            {
                ColorSizeDTO model = new ColorSizeDTO
                {
                    Quantity = obj.Quantity,
                    Color = obj.Color,
                    Size = obj.Size
                };
                return model;
            }
            else
            {
                return null;
            }

        }

        public List<CartDTO> GetAllItems(List<int> items)
        {
            var Product = Genariccart.GetAlls().Include(x => x.Products).ThenInclude(x => x.ListOfImage)
                .Where(w => items.Any(c => c == w.Id)).ToList(); ;
            List<CartDTO> order = new List<CartDTO>();
            foreach (var item in Product)
            {
                order.Add(new CartDTO
                {
                    Id = item.Id,
                    ProductId = item.Products.Id,
                    ProductName = item.Products.Name,
                    Price = item.Products.Price,
                    Images = item.Products.ListOfImage

                });


            }
            return order;

        }
    }
}
