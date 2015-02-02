using System.Runtime.InteropServices.ComTypes;

namespace Functions
{
    public abstract class FunctionBase
    {        
        public abstract FunctionBase Derivative();

        public static CalculatedFunc operator + (FunctionBase a, FunctionBase b)
        {
            return new Function();
        }

    }
}
