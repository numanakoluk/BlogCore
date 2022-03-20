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
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); //programa ne yapmak istedi�imi s�yledim: Her de�i�iklik sonras� program� derlemek zorunda kal�nmayacak.
            services.AddAutoMapper(typeof(Startup)); //DERLENME Esnas�nda automapper s�n�flar� taramas�n� sa�l�yor.Profile'den t�reyen s�n�flar� tar�yor.
            services.LoadMyServices();         //Dependiec injection i�in

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseStatusCodePages(); //hata durumunda
            }
        

            app.UseStaticFiles(); //www.root dosyalar�

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                //routing i�lemi
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
