using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    class ReportsRepository : GenericRepository<Reports>, IReportsRepository
    {
        public ReportsRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
