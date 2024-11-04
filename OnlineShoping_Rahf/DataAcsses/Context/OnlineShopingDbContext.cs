using DataAcsses.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class OnlineShopingDbContext:IdentityDbContext<User, ApplicationRole,int, ApplicationClim,
        ApplicationUserRole,
        ApplicationUserLogin, ApplicationRoleClime, ApplicationUSerToken>
    {
        public OnlineShopingDbContext(DbContextOptions<OnlineShopingDbContext> options) : base(options)
        {



        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.seed();
            base.OnModelCreating(builder);
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.seed();
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=LAPTOP-PH6KVKT3;Database=OnlineShopping;Trusted_Connection=True;MultipleActiveResultSets=true");

        //}

        public DbSet<Products> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CardsPayment> CardsPayments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet <RoleUserGroup> RoleUserGroups { get; set; }
        public DbSet<ProductRollsAdress> ProductRollsAdresses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserAdress> UserAdresses { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<TypeOfLeather> typeOfLeathers { get; set; }
        public DbSet<ProductColorSize> ProductColorSizes { get; set; }
        public DbSet<OrderProduct > OrderProducts { get; set; }
        public DbSet<OrderStatus > OrderStatuses { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<SellerAdress> SellerAdresses { get; set; }






       
       

    }
}
