﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/",async context=>
                {
                    await  context.Response.WriteAsync("Hello from Foxx");
                });
            });
        }
    }
}
