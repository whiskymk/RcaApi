using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    public interface IApplicationContext
    {
        DbSet<Applications> Applications { get; set; }
        DbSet<Reports> Reports { get; set; }
        DbSet<Catalogue> Catalogues { get; set; }
    }
}
