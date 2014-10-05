using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public abstract class Operation
    {
        private readonly FunctionBase leftFunc;
        private readonly FunctionBase rightFunc;

        public Operation(FunctionBase left, FunctionBase right)
        {
            leftFunc = left;
            rightFunc = right;
        }


    }
}
