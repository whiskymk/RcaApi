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

namespace RcaApiBase
{
    public static class Extensions
    {
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

            services.AddScoped<GetAllCaseTypeFlowQuery>();
            services.AddScoped<GetAllCaseTypeQuery>();
            services.AddScoped<GetCaseTypeByCodeQuery>();
            services.AddScoped<GetReferenceValueByCodeQuery>();
            services.AddScoped<GetReferenceValueByIdQuery>();
        }
    }
}
