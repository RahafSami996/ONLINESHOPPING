using DataAcsses.Entity;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
    public interface IColorSize
    {
        List<ProductColorSize> GetAllProductSizes(int id);
        List<ProductColorSize> GetAllProductcolors(int id);
        List<ProductColorSize> GetAllProductQauntity(int id);
        List<Color> GetAllColors();
        void Update(ColorSizeDTO obj);
        List<Size> GetAllsize();
        void InsertColorSize(ProductColorSize obj);

        List<ProductColorSize> GetAllProductSize(int id);
        void DeleteSizeColor(int id);
    }
}
