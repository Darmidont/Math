using System;

namespace Functions
{
    public class Constant : FunctionBase
    {
        private readonly double _value;
        public Constant(double val)
        {
            _value = val;
        }

        public override double Calc(double val)
        {
            return _value;
        }

        public override FunctionBase Derivative()
        {
            return Functions.Zero;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (null == obj)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((Constant) obj);
        }

        protected virtual bool Equals(Constant b)
        {
            if (null == b)
            {
                return false;
            }

            return _value.Equals(b.Calc(0));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static FunctionBase operator *(Constant a, Constant b)
        {
            return new Constant(a.Calc(0) * b.Calc(0));
        }

        public static FunctionBase operator -(Constant a, Constant b)
        {
            return new Constant(a.Calc(0) * b.Calc(0));
        }

        public static FunctionBase operator +(Constant a, Constant b)
        {
            return new Constant(a.Calc(0) * b.Calc(0));
        }

        public static FunctionBase operator /(Constant a, Constant b)
        {
            return new Constant(a.Calc(0) / b.Calc(0));
        }

        public static FunctionBase operator *(double a, Constant b)
        {
            return new Constant(a * b.Calc(0));
        }

        public static FunctionBase operator -(double a, Constant b)
        {
            return new Constant(a * b.Calc(0));
        }

        public static FunctionBase operator +(double a, Constant b)
        {
            return new Constant(a * b.Calc(0));
        }

        public static FunctionBase operator /(double a, Constant b)
        {
            var denominator = b._value;
            if (Math.Abs(0 - denominator) < 0.001)
            {
                throw new ArgumentException("Can't divide on zero");
            }

            return new Constant(a / b.Calc(0));
        }

    }
}
