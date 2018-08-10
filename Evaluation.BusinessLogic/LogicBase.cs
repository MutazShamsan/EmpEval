using Evaluation.DataContextBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation.BusinessLogic
{
    public abstract class LogicBase
    {
        protected AppDataContextBase ApplicationContext { get; private set; }

        public LogicBase(AppDataContextBase context)
        {
            ApplicationContext = context;
        }
    }
}
