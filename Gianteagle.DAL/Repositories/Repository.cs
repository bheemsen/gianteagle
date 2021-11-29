using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Gianteagle.DAL.Repositories.IRepositories;

namespace Gianteagle.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly GianteagleDbContext _DbContext;
        public Repository(GianteagleDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public TEntity Add(TEntity entity)
        {
            _DbContext.Add(entity);
            
            return entity;
        }

        public List<TEntity> AddRange(List<TEntity> entity)
        {
            _DbContext.AddRange(entity);
            _DbContext.SaveChanges();
            return entity;
        }

        public int Delete(TEntity entity)
        {
            var deletedEntry = _DbContext.Remove(entity);
            return _DbContext.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return _DbContext.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return (filter == null ? _DbContext.Set<TEntity>().ToList() : _DbContext.Set<TEntity>().Where(filter).ToList());
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntry = _DbContext.Update(entity);
            _DbContext.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateRange(List<TEntity> entity)
        {
            _DbContext.UpdateRange(entity);
            _DbContext.SaveChanges();
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _DbContext.AddAsync(entity);
            await _DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRangeAsync(List<TEntity> entity)
        {
            await _DbContext.AddRangeAsync(entity);
            await _DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            var deletedEntry = _DbContext.Remove(entity);
            return await _DbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await (filter == null ? _DbContext.Set<TEntity>().ToListAsync() : _DbContext.Set<TEntity>().Where(filter).ToListAsync());
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updatedEntry = _DbContext.Update(entity);
            await _DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entity)
        {
            _DbContext.UpdateRange(entity);
            await _DbContext.SaveChangesAsync();
            return entity;
        }

        public TEntity Get(int id)
        {
            return _DbContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> Get()
        {
            var data = _DbContext.Users.ToList();
            return _DbContext.Set<TEntity>().ToList();
        }
    }
}
