using System;
using System.IO;

namespace consoleapplication1
{
    /// <summary>
    /// Overloading Operators
    /// </summary>

    public class TwoDVector
    {
        public double xcomp;
        public double ycomp;

        public TwoDVector(double x, double y)
        {
            this.xcomp = x;
            this.ycomp = y;
        }

        // Overloading an operator, or giving it new operations so that it performs in a new way
        public static double operator * (TwoDVector first, TwoDVector second)
        {
            return first.xcomp * second.xcomp + first.ycomp * second.ycomp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double xcomp1 = Double.Parse(Console.ReadLine());
            double ycomp1 = Double.Parse(Console.ReadLine());
            TwoDVector vec1 = new TwoDVector(xcomp1, ycomp1);

            double xcomp2 = Double.Parse(Console.ReadLine());
            double ycomp2 = Double.Parse(Console.ReadLine());
            TwoDVector vec2 = new TwoDVector(xcomp2, ycomp2);

            Console.Write("The total price of your purchases is {0}.", vec1*vec2);

            Console.Read();
        }
    }
}