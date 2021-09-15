using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using RcaApiBase.Config;
using Microsoft.EntityFrameworkCore;
using RcaApi.EFCore;
using RcaApiBase.Model;
using RcaApiBase.Model.CRUD.CQRSQueries;
using RcaApiBase.Model.CRUD;


namespace RcaApiBase
{
    public static class Extensions
    {
        public static void SetupDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(
                config.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

            Log.Information($"DbContext is configured");
        }
        public static void SetAuthorizeFilterToEndpoints(MvcOptions options, IConfiguration config)
        {
            var is4Config = config.LoadConfig<IS4Config>();
            if (is4Config is not null)
            {
                var pbuilder = new AuthorizationPolicyBuilder()
                                    .RequireAuthenticatedUser();

                var filter = new AuthorizeFilter(pbuilder.Build());
                options.Filters.Add(filter);
            }
        }

        public static void AddLoader(this IServiceCollection services)
        {
            services.AddScoped<CUD>();

            services.AddScoped<GetAllApplicationsQuery>();
            services.AddScoped<GetAllReportsQuery>();
            services.AddScoped<GetApplicationByIdQuery>();
            services.AddScoped<GetReportByIdQuery>();
            services.AddScoped<GetCatalogueByTypeQuery>();
        }
    }
}
