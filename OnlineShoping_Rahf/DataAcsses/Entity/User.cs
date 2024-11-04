using DataAcsses.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class ApplicationRole : IdentityRole<int> {
        public ApplicationRole() { }
        public ApplicationRole(string name) { Name = name; }
    }
    public class ApplicationUserRole : IdentityUserRole<int> { }
    public class ApplicationUserLogin : IdentityUserLogin<int> { }
    public class ApplicationClim : IdentityUserClaim<int> { }

    public class ApplicationRoleClime : IdentityRoleClaim<int> { }
    public class ApplicationUSerToken : IdentityUserToken<int> { }

    public class User : IdentityUser<int>
    {
        public string Password { get; set; }
        public List<Products> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Image> Images { get; set; }
        public List<Cart> Carts { get; set; }
        public List<CardsPayment> cardsPayments { get; set; }
        public List<UserAdress> UserAdresses { get; set; }
        public List<RoleUser> RoleUsers { get; set; }

        public  List<SellerAdress> SellerAdresses { get; set; }
    }
}
