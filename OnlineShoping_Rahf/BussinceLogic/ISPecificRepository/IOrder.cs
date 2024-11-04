using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinceLogic.ISPecificRepository
{
    public interface IOrder
    {
        void InserOrder(Order obj);
        List<Order> GetOrder(int id);
        void UpdateOrder(Order obj);
        Order GetOrderbyId(int id);
        void DeleteOrder(int id);
        

    }
}
