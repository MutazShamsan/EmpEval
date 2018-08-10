using Evaluation.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Models.Domain
{
    public class Employee : BaseModel, IAuditable, IEntity
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public byte[] Photo { get; set; }

        #region Auditing
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        #endregion
    }
}
