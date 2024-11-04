using DataAcsses.Entity;
using Microsoft.AspNetCore.Http;
using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

namespace BussinceLogic.ISPecificRepository
{
    public interface IProductRepository
    {
        void Insert(ProductDTO obj);
        Products GetProducts(int id);
        ProductDTO GetProductByid(int id);
        List<Products> GetAllProduct(int id);
        List<Products> GetAllProduct();
        Products GetProduct(int id);
        void Delete(int id);
        void Update(ProductDTO obj);
        List<CartDTO> GetAllItems(List<int> items);

        List<Products> GetAllProducts(int id);
        List<Products> GetAllProdectList(int id);
        void InsertToCart(int Id);
        void DeleteCart(int id);
        List<CartDTO> GetAllCartProduct(int id);
    }
}
