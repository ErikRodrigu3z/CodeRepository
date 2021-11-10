using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepository.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private DBContext _db;
        public RepositoryBase()
        {
            _db = new DBContext();
        }

        #region Getters

        public IQueryable<T> FindAll()
        {
            return _db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _db.Set<T>().AsNoTracking().ToListAsync();
        }

        #endregion

        #region Create

        public void Create(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public async Task CreateAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
        }

        #endregion

        #region Delete

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
        }

        #endregion

        #region Update

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
        }


        #endregion
    }
}
