using RcaApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApi.EFCore
{
    public interface ICatalogueRepository : IGenericRepository<Catalogue>
    {
        void CatalogueSetFavoriteItemCode(string code);
        void CatalogueUnSetFavoriteItemCode(string code);
    }
}
