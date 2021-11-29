using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.DAL.Repositories.IRepositories
{
    public interface IRepository<T> where T :  class, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<List<T>> AddRangeAsync(List<T> entity);
        Task<List<T>> UpdateRangeAsync(List<T> entity);


        T Get(int id);
        List<T> Get();
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        int Delete(T entity);
        List<T> AddRange(List<T> entity);
        List<T> UpdateRange(List<T> entity);

    }
}
