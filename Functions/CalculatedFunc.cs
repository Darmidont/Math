using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public abstract class CalculatedFunc : FunctionBase
    {
        public abstract double Calc(double val);

        public readonly double Power;
        protected CalculatedFunc(double power = 1)
        {
            Power = power;
        }
    }
}
