using Evaluation.Interfaces;
using Evaluation.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.IRepository.Domain
{
    public interface IEmployeeEvaluationRepository : IRepository<EmployeeEvaluation>
    {
        Task<IEnumerable<EmployeeEvaluation>> GetAllVotedEmployeesIds(int voterId);
    }
}
