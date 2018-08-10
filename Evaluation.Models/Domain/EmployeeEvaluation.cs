using Evaluation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
    class EmployeeEvaluation : BaseModel, IAuditable, IEntity
    {
        public int VoterEmployeeId { get; set; }
        public int EvaluatedEmployeeId { get; set; }
        public int DepartmentEvaluationAttributeId  { get; set; }
        public int EvaluatedValue { get; set; }

        #region Auditing
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        #endregion
    }
}
