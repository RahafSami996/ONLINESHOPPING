using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcsses.Entity
{
    
     public class ProductColorSize
    {
        public int Id { get; set; }
        public int Quentity { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }

        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
