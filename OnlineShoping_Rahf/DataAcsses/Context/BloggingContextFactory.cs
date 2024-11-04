using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using OnlineShoppingSystem.Models;
using System.IO;
using System.Reflection;

namespace DataAcsses.Context
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<OnlineShopingDbContext>
    {
       
            public OnlineShopingDbContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<OnlineShopingDbContext>();
                builder.UseSqlServer("Server=.;Database=OnlineShopping_Rahaf;Trusted_Connection=True;MultipleActiveResultSets=true",
                    optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(OnlineShopingDbContext).GetTypeInfo().Assembly.GetName().Name));

                return new OnlineShopingDbContext(builder.Options);
            }
        }
    
}
