using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using FirstServer.Services;

namespace FirstServer
{
    public class Startup
    {

        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration _IConfiguration)
        {
            Configuration = _IConfiguration;

        }
        
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            string MARKLink = Configuration["userSettings:MarkLink"];

            services.AddDbContext<Data.FirstServerDbcontext>(option => option.UseSqlServer(MARKLink));

            services.AddGrpc();

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<S_HandleMarkData>();
            });
        }
    }
}
