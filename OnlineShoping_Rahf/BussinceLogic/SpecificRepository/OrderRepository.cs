using BussinceLogic.ISPecificRepository;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinceLogic.SpecificRepository
{
    public class OrderRepository : IOrder
    {
        private readonly IGenaricRepository<Order> GenariOrder;
        public OrderRepository(GenaricRepostory<Order> _GenariOrder)
        {
            GenariOrder = _GenariOrder;
        }
        public void DeleteOrder(int id)
        {
            GenariOrder.Delete(id);
            GenariOrder.Save();
        }

        public List<Order> GetOrder(int id)
        {
            var order = GenariOrder.GetAll();
            return order;

        }

        public Order GetOrderbyId(int id)
        {
            return GenariOrder.GetById(id);
        }

        public void InserOrder(Order obj)
        {
            GenariOrder.Insert(obj);
            GenariOrder.Save();
        }

        public void UpdateOrder(Order obj)
        {
            GenariOrder.Update(obj);
            GenariOrder.Save();
        }
    }
}
