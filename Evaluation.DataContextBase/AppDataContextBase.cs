using Microsoft.EntityFrameworkCore;
using System;
using Evaluation.Models.Domain;

namespace Evaluation.DataContextBase
{
    public abstract class AppDataContextBase : DbContext
    {
        public DbSet<CommunicationType> CommunicationTypes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentEvaluationAttribute> DepartmentEvaluationAttributes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeCommunicationChannel> EmployeeCommunicationChannels { get; set; }
        public DbSet<EmployeeEvaluation> EmployeeEvaluations { get; set; }
        public DbSet<EvaluationAttribute> EvaluationAttributes { get; set; }


        public AppDataContextBase(DbContextOptions<AppDataContextBase> options) : base(options)
        { }
    }
}
