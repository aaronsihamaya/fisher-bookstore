﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Fisher.Bookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            
                routes.MapRoute(
                    name: "about",
                    template: "{controller=About}/{action=Index}/{id?}");
                 
                routes.MapRoute(
                    name: "abouth",
                    template: "{controller=About}/{action=History}/{id?}");

                routes.MapRoute(
                    name: "aboutl",
                    template: "{controller=About}/{action=Location}/{id?}");
                
                routes.MapRoute(
                    name: "booksdefault",
                    template: "{controller=Books}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "booksnew",
                    template: "{controller=Books}/{action=New}/{id?}");

                routes.MapRoute(
                    name: "authorsdefault",
                    template: "{controller=Authors}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "authorsfeatured",
                    template: "{controller=Authors}/{action=Featured}/{id?}");
                
            });
        }
    }
}