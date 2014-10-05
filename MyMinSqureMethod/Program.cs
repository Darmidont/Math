using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMinSqureMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var matrix = MatrixXelper.Getmatrix(5, 2);
            matrix.FillTwoColumnMatrix(GraphicType.Linear, 0.9, 1.1);
            matrix.CalcluateCoeff();
            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }

    public static class MatrixXelper
    {
        public static double[][] Getmatrix(int rows, int columns)
        {
            var matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[columns];
            }

            return matrix;
        }

        public static void FillTwoColumnMatrix(this double[][] matrix, GraphicType graphicType, double decreaseCoeff,
            double increaseCoeff)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        matrix[i][j] = i + 1;
                    }
                    else
                    {
                        matrix[i][j] = (i + 1)*((i + j)%2 == 0 ? decreaseCoeff : increaseCoeff);
                    }}}
        }

        public static Coeff CalcluateCoeff(this double[][] matrix)
        {
            Coeff coeff = new Coeff();
            var rows = matrix.Length;
            //var columns = matrix[0].Length;

          //  var sum = 

            return coeff;
        }
    }

    public class Coeff
    {
        //y = kx + b
        public double K { get; set; }
        public double B { get; set; }
    }

    public enum GraphicType
    {
        Linear,
        Square
    }
}