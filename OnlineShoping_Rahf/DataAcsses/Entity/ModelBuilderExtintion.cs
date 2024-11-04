using Microsoft.EntityFrameworkCore;
using OnlineShoppingSystem.Models;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace DataAcsses.Entity
{
  public static  class ModelBuilderExtintion
    {
        public static void seed(this ModelBuilder builder)
        {
            builder.Entity<OrderStatus>().HasData(
                new OrderStatus
                {
                    Id=1,
                    Name="Drafet"
                },
                 new OrderStatus
                 {
                     Id = 2,
                     Name = "OnWork"
                 },
                 new OrderStatus
                 {
                     Id = 3,
                     Name = "Completed"
                 }

                );
            builder.Entity<Status>().HasData(
               new Status
               {
                   Id=1,
                   Name="Active"
               },
                new Status
                {
                    Id = 2,
                    Name = "UnActive"
                }
);

           builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = 1,
                    Name = "Admin"
                },
                new ApplicationRole
                {
                    Id = 2,
                    Name = "Seller"
                },
                new ApplicationRole
                {
                    Id = 3,
                    Name = "User"
                }
                );
            builder.Entity<Seasons>().HasData(
              new Seasons
              {
                  Id=1,
                  Name= "Winter"
              },
               new Seasons
               {
                   Id = 2,
                   Name = "Summer"
               },
                new Seasons
                {
                    Id = 3,
                    Name = "Spring"
                },
                new Seasons
                {
                    Id = 4,
                    Name = "Autuom"
                }
              );
            builder.Entity<TypeOfLeather>().HasData(
              new TypeOfLeather
              {
                  Id = 1,
                  TypeName = "COttn"
              },
               new TypeOfLeather
               {
                   Id = 2,
                   TypeName = "fiLt"
               },
                new TypeOfLeather
                {
                    Id = 3,
                    TypeName = "silK"
                },
                new TypeOfLeather
                {
                    Id = 4,
                    TypeName = "WOOL"
                },
                new TypeOfLeather
                {
                    Id = 5,
                    TypeName = "satin"
                },
                new TypeOfLeather
                {
                    Id = 6,
                    TypeName = "suede"
                });



            builder.Entity<Country>().HasData(
               new Country
               {
                   Id = 1,
                   Name = "Jordan"
               },
                new Country
                {
                    Id = 2,
                    Name = "Palstian"
                },
                 new Country
                 {
                     Id = 3,
                     Name = "Iraq"
                 },
                 new Country
                 {
                     Id = 4,
                     Name = "Egypt"
                 });


            builder.Entity<City>().HasData(
              new City
              {
                  Id = 1,
                  CountryId = 1,
                  Name = "Amman"
              },
               new City
               {
                   Id = 2,
                   CountryId = 1,
                   Name = "Irbid"
               },
                new City
                {
                    Id = 3,
                    CountryId = 1,
                    Name = "Zarqa"
                },
                new City
                {
                    Id = 4,
                    CountryId = 2,
                    Name = "alquds"
                },
                new City
                {
                    Id = 5,
                    CountryId = 2,
                    Name = "Areha"
                },
                new City
                {
                    Id = 6,
                    CountryId = 2,
                    Name = "Gaza"
                },
                 new City
                 {
                     Id = 7,
                     CountryId = 3,
                     Name = "Baqdad"
                 },
                  new City
                  {
                      Id = 8,
                      CountryId = 3,
                      Name = "Mosul"
                  },
                   new City
                   {
                       Id = 9,
                       CountryId = 3,
                       Name = "Basrah"
                   },

                   new City
                   {
                       Id = 10,
                       CountryId = 4,
                       Name = "Cairo"
                   },
                   new City
                   {
                       Id = 11,
                       CountryId = 4,
                       Name = "Alexandria"
                   },
                   new City
                   {
                       Id = 12,
                       CountryId = 4,
                       Name = "Aswan"
                   });


            builder.Entity<Color>().HasData(
             new Color
             {
                 Id = 1,
                 ColorName = "Black"
             },

              new Color
              {
                  Id =2,
                  ColorName = "Whaite"
              },

               new Color
               {
                   Id = 3,
                   ColorName = "Brown"
               },

                new Color
                {
                    Id = 4,
                    ColorName = "Red"
                },

                 new Color
                 {
                     Id = 5,
                     ColorName = "Pink"
                 }
             );


            builder.Entity<Size>().HasData(
            new Size
            {
                Id=1,
                SizeNumber=35
            },
             new Size
             {
                 Id = 2,
                 SizeNumber = 36
             },
              new Size
              {
                  Id = 3,
                  SizeNumber = 37
              },
               new Size
               {
                   Id = 4,
                   SizeNumber = 38
               },
                new Size
                {
                    Id = 5,
                    SizeNumber = 39
                },
                 new Size
                 {
                     Id = 6,
                     SizeNumber = 40
                 }
            );
        }
    }
}
