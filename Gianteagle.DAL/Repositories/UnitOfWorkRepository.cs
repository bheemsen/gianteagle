using Gianteagle.DAL.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.DAL.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly GianteagleDbContext _DbContext;

        public UnitOfWorkRepository(GianteagleDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public int SaveChanges()
        {
            return this._DbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this._DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._DbContext.Dispose();
        }
    }
}
