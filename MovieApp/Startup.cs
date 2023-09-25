using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // MVC için controller ekledik.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "home", //route ismi
                pattern: "", //url bilgisi anasayfa root url
                defaults: new { controller = "Home", action = "Index" }
                );
                endpoints.MapControllerRoute(
                name: "about", //route ismi
                pattern: "about", //url bilgisi anasayfa root url
                defaults: new { controller = "Home", action = "About" }
                );

                endpoints.MapControllerRoute(
                name: "movieList", //route ismi
                pattern: "movies/list", //url bilgisi
                defaults: new { controller = "Movies", action = "List" }//movies nerede , controller:Controller ismi, action ise List action methodu  
                );//Route Şeması Tanımlanması için azılan method.

                endpoints.MapControllerRoute(
                name: "movieDetails", //route ismi
                pattern: "movies/details", //url bilgisi
                defaults: new { controller = "Movies", action = "Details" }
                );
            });



            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/movies", async context =>
            //    {
            //        await context.Response.WriteAsync("Movie List");
            //    });
            //});

        }
    }
}
