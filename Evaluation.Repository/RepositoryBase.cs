using Evaluation.DataContextBase;
using Evaluation.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Evaluation.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly AppDataContextBase Context;
       
        public RepositoryBase(AppDataContextBase context)
        {
            Context = context;
        }

        public void Add(T source)
        {
            Context.Set<T>().Add(source);
        }

        public void AddRange(IEnumerable<T> source)
        {
            Context.Set<T>().AddRange(source);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicat)
        {
            return Context.Set<T>().Where(predicat);
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Remove(T source)
        {
            Context.Set<T>().Remove(source);
        }

        public void RemoveRange(IEnumerable<T> source)
        {
            Context.Set<T>().RemoveRange(source);
        }
    }
}
