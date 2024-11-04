using DataAcsses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Size
    {
        public int Id { get; set; }
        public int SizeNumber { get; set; }
        public List<ProductColorSize> ColorSize { get; set; }
    }
}
