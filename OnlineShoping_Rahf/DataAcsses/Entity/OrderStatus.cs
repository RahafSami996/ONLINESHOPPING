using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcsses.Entity
{
   public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> order { get; set; }
    }
}
