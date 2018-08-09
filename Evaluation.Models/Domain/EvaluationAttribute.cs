using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
    class EvaluationAttribute : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
