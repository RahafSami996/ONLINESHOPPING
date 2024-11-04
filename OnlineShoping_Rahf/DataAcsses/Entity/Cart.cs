using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Products")]
        public int ProductID { get; set; }
        public Products Products { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public User user { get; set; }
       
        public Order Order { get; set; }
    }
}
