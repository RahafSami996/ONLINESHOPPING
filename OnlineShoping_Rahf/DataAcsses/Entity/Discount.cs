using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public double Value { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }
        public DateTime ExpireDate { get; set; }
        public List<Order> Orders { get; set; }

        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
