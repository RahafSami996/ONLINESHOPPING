using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CardsPayment> CardsPayments { get; set; }
    }
}
