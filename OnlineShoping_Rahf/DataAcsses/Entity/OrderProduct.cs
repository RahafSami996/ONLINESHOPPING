using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcsses.Entity
{
   public class OrderProduct
    {
        public int Id { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }

        [ForeignKey("ProductColorSize")]
        public int productcolorsizeId { get; set; }
        public ProductColorSize ProductColorSize { get; set; }

      

        [ForeignKey("Order")]
        public int orderid { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }


    }
}
