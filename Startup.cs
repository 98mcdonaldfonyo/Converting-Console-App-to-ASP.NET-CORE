﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection service)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//used as a middleware(service that speaks to the requests and responses)//routing
        {
            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
            }
          

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>//mapGet-default () for Middleware-handles requests but Map()handles requests and Responses
                 {
                     await context.Response.WriteAsync(" Hello from Foxx");
                 });


            });


        }

    }
}
