
using System;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;
using AutoPartsShop.Repositories;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AutoPartsShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Constructor to assign the configuration property value.
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AutoPartsShopDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AutoPartsShopContext")));

            services.AddControllersWithViews();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPartRepository, PartRepository>();
            services.AddScoped<Cart>(c => Cart.GetCart(c));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddHttpContextAccessor();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                // TODO: Jaime, remember to disable this prior to go live!;
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Use this route options to route the application to the initial page desired.
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

            MigrateAndSeedData(serviceProvider);
        }

        public static IServiceProvider MigrateAndSeedData(IServiceProvider serviceProvider)
        {
            using var context = serviceProvider.GetService<AutoPartsShopDbContext>();

            if (!context.Database.CanConnect())
                return serviceProvider;

            context.Database.Migrate();

            return serviceProvider;
        }
    }
}
