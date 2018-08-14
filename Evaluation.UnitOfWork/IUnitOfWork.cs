using Evaluation.IRepository.Domain;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        Task<IDbContextTransaction> BeginTransactionAsync();
        void CommiTransaction(IDbContextTransaction transaction);
        void RollbackTransaction(IDbContextTransaction transaction);
        Task<int> CompleteAsync();
    }
}
