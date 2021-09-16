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
using ParameterizationStore.Client.Client;
using RcaApiBase.Model.ParamApi;

namespace RcaApiBase
{
    public static class Extensions
    {
        static IDictionary<string, string> empty = new Dictionary<string, string>();

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
            services.AddScoped<Loader>();
        }
        public static void AddApis (this IServiceCollection services)
        {
            services.AddScoped<ParameterizationStore.Client.Api.IDefaultApi, ParameterizationStore.Client.Api.DefaultApi>();
        }
        public static void SetIdentityServerTokenValidation(this IServiceCollection services, IConfiguration config)
        {
            var is4Config = config.LoadConfig<IS4Config>();
            if (is4Config is not null)
            {
                services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(o =>
                {
                    o.Authority = is4Config.Authority;
                    o.Audience = is4Config.Audience;
                    o.RequireHttpsMetadata = false;
                });
            }

        }
        public static void AddClient(this IServiceCollection services)
        {
            services.AddSingleton(GetClientConfig);
        }
        public static Configuration GetClientConfig(IServiceProvider serviceProvider)
        {
            var config = serviceProvider.GetService<ApiClientSettings>();
            var url = new Uri(new Uri(config.Endpoint.BaseAddress), config.Endpoint.Path).ToString();
            var res = new Configuration(empty, empty, empty, url);
            return res;

        }
        public static void AddConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddConfig<ApiClientSettings>(configuration);
            
        }
    }
}
