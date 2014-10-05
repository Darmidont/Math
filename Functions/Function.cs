using System;

namespace Functions
{
    public class Function : FunctionBase
    {
        public Function(double power = 1) : base(power)
        {            
        }
        public override double Calc(double val)
        {
            return Math.Pow(val, Power);
        }

        public override FunctionBase Derivative()
        {
            if (Math.Abs(1 - Power) < 0.01)
            {
                return new Constant(Power);
            }

            return new Function(Power - 1);
        }

        public override string ToString()
        {
            return string.Format("x ^ {0}", Power);
        }


    }
}
