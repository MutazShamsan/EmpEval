using Evaluation.DataContextBase;
using Evaluation.IRepository.Domain;
using Evaluation.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Evaluation.Repository.Domain
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDataContextBase context) : base(context) { }

        public async Task<IEnumerable<Employee>> GetAllExceptLoggedInUser(int loggedinId)
        {
            return await Context.Employees.Where(st => st.Id != loggedinId).ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetUnvotedEmployees(int loggedinId)
        {
            var voted = await GetVotedEmployeeIds(loggedinId);
            return await Context.Employees.Where(st => !voted.Contains(st.Id)).ToListAsync();
        }

        public async Task<IEnumerable<int>> GetVotedEmployeeIds(int loggedinId)
        {
            return await Context.EmployeeEvaluations.Where(st => st.VoterEmployeeId == loggedinId).Select(st => st.EvaluatedEmployeeId).ToListAsync();
        }
    }
}
