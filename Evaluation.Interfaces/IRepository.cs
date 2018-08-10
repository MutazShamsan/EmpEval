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

        Task UpdateAsync(T source);
        Task UpdateRangeAsync(IEnumerable<T> source);

        Task RemoveAsync(T source);
        Task RemoveRangeAsync(IEnumerable<T> source);

        Task<IQueryable<T>> SelectAsync();

        Task<bool> Commit();
    }
}
