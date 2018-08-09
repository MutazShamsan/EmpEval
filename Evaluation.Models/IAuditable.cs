using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.Models
{
    public interface IAuditable
    {
        DateTimeOffset CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset ModifiedDate { get; set; }
        string ModifiedBy { get; set; }

    }
}
