using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTest.Data.Interfaces;
using ASPTest.Data.Mocks;
using Microsoft.Extensions.Configuration;
using ASPTest.Data;
using ASPTest.Data.Repository;
using Microsoft.EntityFrameworkCore;
using ASPTest.Data.Models;

namespace ASPTest
{
    public class Startup
    {

        private IConfigurationRoot _confString;
        public Startup(IHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarCategory, CategoryRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddMemoryCache();
            services.AddSession();

            services.AddMvc(option => option.EnableEndpointRouting = false);
           
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();

            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
