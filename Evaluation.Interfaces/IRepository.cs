using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task AddAsync(T source);
        Task AddRangeAsync(IEnumerable<T> source);

        void UpdateAsync(T source);
        void UpdateRangeAsync(IEnumerable<T> source);

        void RemoveAsync(T source);
        void RemoveRangeAsync(IEnumerable<T> source);

        IQueryable<T> SelectAsync();

        Task<bool> Commit();
    }
}
