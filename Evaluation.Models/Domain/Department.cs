using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evaluation.Models.Domain
{
    public class Department: BaseModel, IAuditable
    {       
        public string Name { get; set; }

        #region Auditing
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        #endregion
    }
}
