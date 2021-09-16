using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    class CatalogueRepository : GenericRepository<Catalogue>, ICatalogueRepository
    {
        public CatalogueRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
