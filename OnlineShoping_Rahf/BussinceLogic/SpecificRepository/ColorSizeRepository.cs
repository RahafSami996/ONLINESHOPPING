using BussinceLogic.ISPecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.SpecificRepository
{
   public class ColorSizeRepository:IColorSize
    {
        private readonly IGenaricRepository<Color> GenaricColor;
        private readonly IGenaricRepository<Size> GenaricSize;
        private readonly IGenaricRepository<ProductColorSize> GenaricSizeColor;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ColorSizeRepository(GenaricRepostory<Color> _GenaricColor, GenaricRepostory<Size> _GenaricSize,
            GenaricRepostory<ProductColorSize> _GenaricSizeColor, IHttpContextAccessor _httpContextAccessor)
        {
            GenaricColor = _GenaricColor;
            GenaricSize = _GenaricSize;
            GenaricSizeColor = _GenaricSizeColor;
            httpContextAccessor = _httpContextAccessor;
        }

        public List<Color> GetAllColors()
        {
            return GenaricColor.GetAll();
        }

        public List<ProductColorSize> GetAllProductSize(int id)
        {
            var AllProduct = GenaricSizeColor.GetAlls()
                .Include(a => a.Color)
                .Include(a => a.Size).
                  Where(a => a.ProductId == id).ToList();
            return AllProduct;
        }
        public List<ProductColorSize> GetAllProductSizes(int id)
        {
            var AllProduct = GenaricSizeColor.GetAlls()
                .Include(a => a.Size).
                  Where(a => a.ProductId == id).ToList();
            return AllProduct;
        }

        public List<ProductColorSize> GetAllProductQauntity(int id)
        {
            var AllProduct = GenaricSizeColor.GetAlls()
                .Include(a => a.Quentity).
                  Where(a => a.ProductId == id).ToList();
            return AllProduct;
        }
        public List<ProductColorSize> GetAllProductcolors(int id)
        {
            var AllProduct = GenaricSizeColor.GetAlls()
                .Include(a => a.Color).
                  Where(a => a.ProductId == id).ToList();
            return AllProduct;
        }

        public List<Size> GetAllsize()
        {
            return GenaricSize.GetAll();
        }

        public void InsertColorSize(ProductColorSize obj)
        {

            GenaricSizeColor.Insert(obj);
            GenaricSizeColor.Save();
        }

        public void DeleteSizeColor(int id)
        {
            GenaricSizeColor.Delete(id);
            GenaricSizeColor.Save();
        }
        public void Update(ColorSizeDTO obj)
        {
            var repet = Repet(obj);
            if (repet == null)
            {
                ProductColorSize productColor = new ProductColorSize
                {
                    Quentity=obj.Quantity,
                    SizeId=obj.Size,
                    ColorId=obj.Color

                };
                GenaricSizeColor.Update(productColor);
                GenaricSizeColor.Save();
            }
            else
            {

            }
           
        }
        public ColorSizeDTO Repet(ColorSizeDTO obj)
        {
            var userid = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
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
    }
}
