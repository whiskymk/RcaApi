using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.Reflection;

namespace RcaApiBase
{
    public static class ConnectionString
    {
        public static void SetupDbAdoNet(this IServiceCollection services, IConfiguration config)
        {
            cName = config.GetConnectionString("DefaultConnection");
        }
        private static string cName;
        public static string CName
        {
            get => cName;
        }
    }
}

