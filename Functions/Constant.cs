using System;

namespace Functions
{
    public class Constant : ConstantFuncBase
    {
        private readonly double _value;
        public Constant(double val)
        {
            _value = val;
        }

        public override double Calc()
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

            return _value.Equals(b.Calc());
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static FunctionBase operator *(Constant a, Constant b)
        {
            return new Constant(a.Calc() * b.Calc());
        }

        public static FunctionBase operator -(Constant a, Constant b)
        {
            return new Constant(a.Calc() - b.Calc());
        }

        public static FunctionBase operator +(Constant a, Constant b)
        {
            return new Constant(a.Calc() + b.Calc());
        }

        public static FunctionBase operator /(Constant a, Constant b)
        {
            return new Constant(a.Calc() / b.Calc());
        }

        public static FunctionBase operator *(double a, Constant b)
        {
            return new Constant(a * b.Calc());
        }

        public static FunctionBase operator -(double a, Constant b)
        {
            return new Constant(a - b.Calc());
        }

        public static FunctionBase operator +(double a, Constant b)
        {
            return new Constant(a + b.Calc());
        }

        public static FunctionBase operator /(double a, Constant b)
        {
            var denominator = b._value;
            if (Math.Abs(0 - denominator) < PredefinedConstants.MinComparedValue)
            {
                throw new ArgumentException("Can't divide on zero");
            }

            return new Constant(a / b.Calc());
        }

        public static FunctionBase operator *(Constant b, double a)
        {
            return (a*b);
        }

        public static FunctionBase operator -(Constant b, double a)
        {
            return new Constant(b.Calc() - a);
        }

        public static FunctionBase operator +(Constant b, double a)
        {
            return (a + b);
        }

        public static FunctionBase operator /(Constant a, double b)
        {
            if (Math.Abs(0 - b) < PredefinedConstants.MinComparedValue)
                throw new ArgumentException("Can't divide on zero");

            return new Constant(a.Calc() /b);
        }
    }
}
