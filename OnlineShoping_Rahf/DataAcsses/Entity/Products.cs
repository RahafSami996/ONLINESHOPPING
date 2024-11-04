using DataAcsses.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Season")]
        [Display(Name ="Season")]
        public int SeasonId { get; set; }
        public Seasons Season { get; set; }

        [ForeignKey("TypeOfLeather")]
        [Display(Name ="Type Of Leather")]
        public int TypeId { get; set; }
        public TypeOfLeather TypeOfLeather { get; set; }


        public string Code { get; set; }
        public ICollection<ProductColorSize> ProductColorSizes { get; set; }
        public virtual ICollection<Image> ListOfImage { get; set; }
        [ForeignKey("User")]
        [Display(Name ="Seller")]
        public int SellerID { get; set; }
        public User User { get; set; }
    }
}
