using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    class ApplicationsRepository : GenericRepository<Applications>, IApplicationsRepository
    {
        public ApplicationsRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
