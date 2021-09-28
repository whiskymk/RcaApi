using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RcaApi.Domain;

namespace RcaApi.EFCore
{
    public class CatalogueRepository : GenericRepository<Catalogue>, ICatalogueRepository
    {
        public CatalogueRepository(ApplicationContext context) : base(context)
        {

        }
        public void CatalogueSetFavoriteItemCode(string code)
        {
            var entity = _context.Catalogues.Where(x => x.Code.Equals(code))?.FirstOrDefault();
            if(entity !=null)
            {
                entity.IsFavorite = true;
            }            
        }

        public void CatalogueUnSetFavoriteItemCode(string code)
        {
            var entity = _context.Catalogues.Where(x => x.Code.Equals(code))?.FirstOrDefault();
            if (entity != null)
            {
                entity.IsFavorite = false;
            }
        }
    }
}
