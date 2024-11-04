using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class RoleUser
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public virtual RoleUserGroup RoleUserGroup { get; set; }


        public int Userid { get; set; }
        public virtual User User { get; set; }
    }
}
