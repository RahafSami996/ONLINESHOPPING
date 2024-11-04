using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class TypeOfLeather
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public List<Products> Products { get; set; }
    }
}
