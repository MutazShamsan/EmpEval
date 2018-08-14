using Evaluation.Interfaces;
using Evaluation.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.IRepository.Domain
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetAllExceptLoggedInUser(int loggedinId);
    }
}
