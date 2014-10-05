using System;

namespace Functions
{
    public class Function : CalculatedFunc
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
            if (Math.Abs(1 - Power) < PredefinedConstants.MinComparedValue)
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
