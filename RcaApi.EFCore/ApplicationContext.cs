using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Catalogue> Catalogues { get; set; }

    }
}
