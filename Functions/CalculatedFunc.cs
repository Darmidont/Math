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

        public readonly double Coeff;

        //protected CalculatedFunc(double coeff =1,  double power = 1)
        protected CalculatedFunc(double coeff, double power)
        {
            Power = power;
            Coeff = coeff;
        }
    }
}
