using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quipu.RcaApiBase.OpenApi.Controllers;
using Serilog;
using System.Reflection;
using RcaApiBase;

using System.Text.Json.Serialization;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace RcaApi
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

            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
                 .Build();

            services.AddControllersWithViews();

            services.SetIdentityServerTokenValidation(config);

            services.AddLoader();
            services.SetupDbContext(config);
            services.SetupDbAdoNet(config);

            services.AddControllers(_ => RcaApiBase.Extensions.SetAuthorizeFilterToEndpoints(_, config))
                .AddJsonOptions(x =>
                        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            Log.Information($"Adding controllers from Assembly: {typeof(ApplicationsApiController).Assembly} ");
            services.AddControllers()
                .AddApplicationPart(typeof(ApplicationsApiController).Assembly)
                .AddControllersAsServices();
            Log.Information($"Added controllers from Assembly: {typeof(ApplicationsApiController).Assembly} ");

            services.AddConfigurations(config);
            services.AddClient();
            services.AddApis();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RcaApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RcaApi v1"));
            }

          //  app.UseHttpsRedirection();

            app.UseStaticFiles();


            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
