using Evaluation.IRepository.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.UnitOfWork
{
   public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        Task<int> Complete();
    }
}
