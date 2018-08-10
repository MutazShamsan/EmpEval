using Evaluation.DataContextBase;
using Evaluation.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.Repository
{
    public class AppRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly AppDataContextBase _dataContext;
        private readonly DbSet<T> _dbSet;

        public AppRepository(AppDataContextBase context)
        {
            _dataContext = context;
            _dbSet = _dataContext.Set<T>();
        }

        public Task AddAsync(T source)
        {
            return _dbSet.AddAsync(source);
        }

        public Task AddRangeAsync(IEnumerable<T> source)
        {
            return _dbSet.AddRangeAsync(source);
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(T source)
        {
            _dbSet.Remove(source);
        }

        public void RemoveRangeAsync(IEnumerable<T> source)
        {
            _dbSet.RemoveRange(source);
        }

        public IQueryable<T> SelectAsync()
        {
            return _dbSet;
        }

        public void UpdateAsync(T source)
        {
            _dbSet.Update(source);
        }

        public void UpdateRangeAsync(IEnumerable<T> source)
        {
            _dbSet.UpdateRange(source);
        }
    }
}
