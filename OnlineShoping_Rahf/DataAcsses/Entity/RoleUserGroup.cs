using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class RoleUserGroup : IdentityRole
    {
        public List<RoleUser> RoleUsers { get; set; }
    }
}
