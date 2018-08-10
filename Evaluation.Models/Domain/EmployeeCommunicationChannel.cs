using Evaluation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
   public class EmployeeCommunicationChannel : BaseModel, IEntity
    {
        public int EmployeeId { get; set; }
        public int CommunicationTypeId { get; set; }
        public string Value { get; set; }
    }
}
