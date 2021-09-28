using RcaApi.EFCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApi.EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Applications = new ApplicationsRepository(_context);
            Catalogues = new CatalogueRepository(_context);
            Reports = new ReportsRepository(_context);
        }

        public IApplicationsRepository Applications { get; private set; }

        public ICatalogueRepository Catalogues { get; private set; }

        public IReportsRepository Reports { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    } 
}
