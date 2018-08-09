using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evaluation.Models.Domain
{
    class Company : BaseModel, IAuditable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsDepartmentEvaluationAttributeWeightRequired { get; set; }
        public bool IsEvaluationAttributePercentageRequired { get; set; }
        
        #region Auditing
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        #endregion
    }
}
