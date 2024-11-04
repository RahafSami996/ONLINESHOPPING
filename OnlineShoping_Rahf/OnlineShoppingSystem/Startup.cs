using Autofac;
using Autofac.Extensions.DependencyInjection;
using BussinceLogic.ISPecificRepository;
using BussinceLogic.SpecificRepository;
using DataAcsses.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.Models.Genaric;
using Scrutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OnlineShoppingSystem
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            this.configuration = configuration;

            var builder = new ConfigurationBuilder()
           .SetBasePath(env.ContentRootPath)
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
           .AddEnvironmentVariables();
           this.configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();


            services.AddDbContext<OnlineShopingDbContext>(options => { options.UseSqlServer(configuration.GetConnectionString("ConSql")); });

            services.AddIdentity<User, ApplicationRole>()
                .AddEntityFrameworkStores<OnlineShopingDbContext>().AddSignInManager<SignInManager<User>>()
                .AddRoleManager<RoleManager<ApplicationRole>>()
                .AddDefaultTokenProviders();

            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(1000);
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            //services.AddMvc();

            //services.Scan(scan => scan
            //         .FromAssemblyOf<CommanServer>()
            //         .AddClasses(classes => classes.AssignableTo<ICommanServer>())
            //         .AsImplementedInterfaces()
            //         .WithSingletonLifetime());

            //services.Scan(scan => scan
            //        .FromAssemblyOf<ProductRepository>()
            //        .AddClasses(classes => classes.AssignableTo<IProductRepository>())
            //        .AsImplementedInterfaces()
            //        .WithSingletonLifetime());

            services.Scan(sc =>
            sc.FromAssemblies()
              .FromAssemblies(
                typeof(ProductRepository).Assembly,
                typeof(CommanServer).Assembly
            )
            .AddClasses()
            .AsImplementedInterfaces()
        );


            var builder = new ContainerBuilder();
            builder.RegisterGeneric(typeof(IGenaricRepository<>)).AsImplementedInterfaces();

            //builder.RegisterType<ProductRepository>().As<IProductRepository>();
            //builder.RegisterType<CommanServer>().As<ICommanServer>();


            //builder.Build();

            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<ICommanServer, CommanServer>();

            //var builder = new ContainerBuilder();
            //builder
            //   .RegisterGeneric(typeof(GenaricRepostory<>))
            //   .As(typeof(IGenaricRepository<>))
            //   .InstancePerLifetimeScope();

            //var container = builder.Build();
            //builder.RegisterGeneric(typeof(GenaricRepostory<>)).As(typeof(IGenaricRepository<>)).InstancePerRequest();


            services.AddScoped<GenaricRepostory<Products>>();
            services.AddScoped<GenaricRepostory<Color>>();
            services.AddScoped<GenaricRepostory<Size>>();
            services.AddScoped<GenaricRepostory<ProductColorSize>>();
            services.AddScoped<GenaricRepostory<City>>();
            services.AddScoped<GenaricRepostory<Country>>();
            services.AddScoped<GenaricRepostory<Seasons>>();
            services.AddScoped<GenaricRepostory<TypeOfLeather>>();
            services.AddScoped<GenaricRepostory<SellerAdress>>();
            services.AddScoped<GenaricRepostory<Image>>();
            services.AddScoped<GenaricRepostory<UserAdress>>();
            services.AddScoped<GenaricRepostory<Status>>();
            services.AddScoped<GenaricRepostory<CardsPayment>>();
            services.AddScoped<GenaricRepostory<Cart>>();
            services.AddScoped<GenaricRepostory<Order>>();



            {
                services.Configure<PasswordHasherOptions>(options =>
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3
                      );
               

            }
        }

        //public void ConfigureContainer(ContainerBuilder builder)
        //{
        //    builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
        //    .AsClosedTypesOf(typeof(IGenaricRepository<>));



        //}
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
            app.UseDeveloperExceptionPage();
            app.UseFileServer();
            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Login}/{action=SignIn}/{id?}");
            });
        }

        
    }
}
