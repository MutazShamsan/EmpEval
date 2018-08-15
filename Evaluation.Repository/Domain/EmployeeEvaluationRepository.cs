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
    public class EmployeeEvaluationRepository : RepositoryBase<EmployeeEvaluation>, IEmployeeEvaluationRepository
    {
        public EmployeeEvaluationRepository(AppDataContextBase context) : base(context) { }

        public Task<IEnumerable<EmployeeEvaluation>> GetAllVotedEmployeesIds(int voterId)
        {
            throw new NotImplementedException();
        }
    }
}
