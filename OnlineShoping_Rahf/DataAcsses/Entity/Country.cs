using DataAcsses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> ListOfCity { get; set; }
        public List<UserAdress> UserAdresses { get; set; }
        public List<User> ListOfUser { get; set; }
        public List<SellerAdress> SellerAdresses { get; set; }

    }
}
