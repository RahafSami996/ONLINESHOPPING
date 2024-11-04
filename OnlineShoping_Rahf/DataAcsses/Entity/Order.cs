using DataAcsses.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
       
        public double? TotalPrice { get; set; }
        public double? NetTotalPrice { get; set; }
       
        [ForeignKey("user")]
        public int UserId { get; set; }
        public User user { get; set; }

        [ForeignKey("UserAdress")]
        public int? USerAddressId { get; set; }
        public UserAdress UserAdress { get; set; }

        [ForeignKey("CardsPayment")]
        public int? cardPayment { get; set; }
        public CardsPayment CardsPayment { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatesId { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
