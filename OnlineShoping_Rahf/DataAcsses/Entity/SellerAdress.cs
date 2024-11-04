using OnlineShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAcsses.Entity
{
   public class SellerAdress
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int SellerId { get; set; }
        public  User User { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country  { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
