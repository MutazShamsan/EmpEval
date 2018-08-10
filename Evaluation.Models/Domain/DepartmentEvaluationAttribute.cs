using Evaluation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
    class DepartmentEvaluationAttribute : BaseModel, IEntity
    {
        public int DepartmentId { get; set; }
        public int EvaluationAttributeId { get; set; }
        public int Weight { get; set; }
    }
}
