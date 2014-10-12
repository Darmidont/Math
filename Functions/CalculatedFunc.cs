namespace Functions
{
    public abstract class CalculatedFunc : FunctionBase
    {
        public abstract double Calc(double val);

        public readonly double Power;

        public readonly double Coeff;

        protected CalculatedFunc(double coeff = 1, double power = 1)
        {
            Power = power;
            Coeff = coeff;
        }
    }
}
