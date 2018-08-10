using Evaluation.DataContextBase;
using Evaluation.Interfaces;
using Evaluation.Models.Domain;
using Evaluation.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.BusinessLogic
{
    public class EmployeeManagement : LogicBase
    {

        public EmployeeManagement(AppDataContextBase context) : base(context)
        { }

        public Employee Get(int id)
        {
            Employee result = null;

            var repo = new AppRepository<Employee>(ApplicationContext);
            result = repo.SelectAsync().FirstOrDefault(st => st.Id == id);

            return result;
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> result = new List<Employee>();

            var repo = new AppRepository<Employee>(ApplicationContext);
            result = await repo.SelectAsync().ToListAsync();

            return result;
        }
    }
}
