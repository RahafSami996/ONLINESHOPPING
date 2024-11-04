using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinceLogic.ISPecificRepository;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingSystem.Models;
using static OnlineShoppingSystem.Models.DTOOnlineShopping;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShoppingSystem.Controllers
{
    public class OrderProduct : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IOrder OrderRepository;
        public OrderProduct(IProductRepository _productRepository, IOrder _OrderRepository)
        {
            productRepository = _productRepository;
            OrderRepository = _OrderRepository;
        }
        // GET: /<controller>/

        //public IActionResult SaveOrder(List<int> ListOrder,Order obj)
        //{

        //    OrderRepository.InserOrder(obj);

        //    return View();
        //}

        public IActionResult GetOrderProduct(List<int> ListOrder)
        {
            var Items = productRepository.GetAllItems(ListOrder);


            return View(Items);
        }
    }
}
