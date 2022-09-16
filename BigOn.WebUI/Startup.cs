using BigOn.WebUI.Models.DataContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configurtaion;

        //database ile ishleyirik (connectionstring ve appsettingsi oxumag lazimdi)
        public Startup(IConfiguration configurtaion)
        {
            this.configurtaion = configurtaion;
        }

        //projectde olan servics (controllerin views ile ishlemesi)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //bu configurationun meqsedi  BigOnDbContext class uchun bir option yaratsin
            services.AddDbContext<BigOnDbContext>(cfg =>{
                cfg.UseSqlServer(configurtaion["ConnectionStrings:cString"]);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //sehifeler arasi kechid uchun UseRouting 
            app.UseRouting();
            //wwwroot css ve js files oxumag ucun
            app.UseStaticFiles();


            //linkin son pointini set elirik
            app.UseEndpoints(cfg =>
            {
                cfg.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
