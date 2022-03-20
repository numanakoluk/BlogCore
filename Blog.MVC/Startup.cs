using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); //programa ne yapmak istediðimi söyledim: Her deðiþiklik sonrasý programý derlemek zorunda kalýnmayacak.
            services.AddAutoMapper(typeof(Startup)); //DERLENME Esnasýnda automapper sýnýflarý taramasýný saðlýyor.Profile'den türeyen sýnýflarý tarýyor.
            services.LoadMyServices();         //Dependiec injection için

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseStatusCodePages(); //hata durumunda
            }
        

            app.UseStaticFiles(); //www.root dosyalarý

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //routing iþlemi
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
