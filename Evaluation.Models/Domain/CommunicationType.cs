using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models.Domain
{
    public class CommunicationType : BaseModel
    {
        public string Name { get; set; }
        public int MaxPerEmployee { get; set; }
    }
}
