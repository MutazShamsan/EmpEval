using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evaluation.DataContextBase;
using Evaluation.IRepository.Domain;
using Evaluation.Repository.Domain;
using Microsoft.EntityFrameworkCore.Storage;

namespace Evaluation.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDataContextBase _context;

        public IEmployeeRepository Employees { get; private set; }

        public UnitOfWork(AppDataContextBase context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
        }

        public Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return _context.Database.BeginTransactionAsync();
        }

        public void CommiTransaction(IDbContextTransaction transaction)
        {
            transaction.Commit();
        }

        public void RollbackTransaction(IDbContextTransaction transaction)
        {
            transaction.Rollback();
        }

        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Database?.CurrentTransaction?.Dispose();
            _context?.Dispose();
        }
    }
}
