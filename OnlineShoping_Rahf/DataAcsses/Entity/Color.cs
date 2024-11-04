using DataAcsses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public List<ProductColorSize> ProductColorSizes { get; set; }
    }
}
