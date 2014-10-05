using System;

namespace Functions
{
    public class Function : CalculatedFunc
    {
        public Function(double coeff = 1, double power = 1) : base(coeff, power)
        {            
        }
        public override double Calc(double val)
        {
            return Coeff * Math.Pow(val, Power);
        }

        public override FunctionBase Derivative()
        {
            if (Math.Abs(1 - Power) < PredefinedConstants.MinComparedValue)
            {
                return new Constant(Power * Coeff);
            }

            return new Function(Power * Coeff, Power - 1);
        }

        public override string ToString()
        {
            if (Math.Abs(1 - Coeff) < PredefinedConstants.MinComparedValue)
            {
                return string.Format("x ^ {0}", Power);
            }

            return string.Format("{0} * x ^ {1}", Coeff, Power);
        }
    }
}
