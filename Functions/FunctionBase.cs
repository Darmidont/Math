namespace Functions
{
    public abstract class FunctionBase
    {
        public abstract double Calc(double val);
        public abstract FunctionBase Derivative();

        public readonly double Power;

        protected FunctionBase(double power = 1)
        {
            Power = power;
        }
    }
}
