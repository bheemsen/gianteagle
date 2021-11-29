using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.DAL.Repositories.IRepositories
{
    public interface IUnitOfWorkRepository : IDisposable
    {          
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
