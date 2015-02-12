using System;

namespace consoleapplication1
{
    /// <summary>
    /// Lambda Expression Basics
    /// </summary>

    class Program
    {
        delegate int Multiply(int x, int y);

        delegate double Add(double x, double y);

        static void Main(string[] args)
        {
            Multiply ybyx = (y, x) => (y*x);
            Console.WriteLine("The product of 4 and 6 is {0}.", ybyx(4, 6));

            Add ytox = (y, x) => (y + x);
            Console.WriteLine("The sum of 4 and 6 is {0}.", ytox(4, 6));

            Console.Read();
        }
    }
}