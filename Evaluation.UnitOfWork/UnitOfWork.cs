using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evaluation.DataContextBase;
using Evaluation.IRepository.Domain;
using Evaluation.Repository.Domain;

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


        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
