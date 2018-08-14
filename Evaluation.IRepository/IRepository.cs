using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Evaluation.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicit);
        void Add(T source);
        void AddRange(IEnumerable<T> source);
        void Remove(T source);
        void RemoveRange(IEnumerable<T> source);
    }
}
