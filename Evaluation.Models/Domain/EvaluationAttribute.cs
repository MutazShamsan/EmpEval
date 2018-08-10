using Evaluation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
    class EvaluationAttribute : BaseModel, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
