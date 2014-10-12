using System;
using System.Globalization;

namespace Functions
{
    public class Function : CalculatedFunc
    {
        #region const
        private const string FunctionTemplate = "{0} * x ^ {1}";
        private const string NoCoeffFunctionTemplate = "x ^ {0}";
        private const string NoPowerFunctionTemplate = "{0} * ";
        private const string SimpleFunction = "x";
        #endregion
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
            if (Math.Abs(0 - Coeff) < PredefinedConstants.MinComparedValue)
            {
                return 0.ToString(CultureInfo.InvariantCulture);
            }

            //if (Math.Abs(0 - Coeff))

            if (Math.Abs(1 - Coeff) < PredefinedConstants.MinComparedValue &&
                Math.Abs(1 - Power) < PredefinedConstants.MinComparedValue)
            {
                return SimpleFunction;
            }

            if (Math.Abs(1 - Coeff) < PredefinedConstants.MinComparedValue)
            {
                return FunctionStringVal(NoCoeffFunctionTemplate, Power);
            }

            if (Math.Abs(1 - Coeff) < PredefinedConstants.MinComparedValue)
            {
                return FunctionStringVal(NoPowerFunctionTemplate, Power);
            }

            return FunctionStringVal(FunctionTemplate, new object[] {Coeff, Power});
        }

        

        private string FunctionStringVal(string template, params object[] args)
        {
            try
            {
                return string.Format(template, args);
            }
            catch (Exception ex)
            {
                var dd = ex.ToString();
                throw;
            }
            
        }
    }
}
