using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Create a class, add four functions, understand variable scope

    class calculator
    {
        public calculator()
        {
            Console.WriteLine("We are making a calculator object.");
        }

        // All of the variables are local variables and copied
        // Scoped only to the method
        // Anything that happens to the variables in the methods, it does not change the original value of the variables.
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator(); // Declare and reserve memory for a calculator object

            double x = 4; double y = 6;
            Console.WriteLine("The sum of {0} and {1} is {2}.", x, y, calc.Add(x, y));
            Console.WriteLine("The difference of {0} and {1} is {2}.", x, y, calc.Subtract(x, y));
            Console.WriteLine("The product of {0} and {1} is {2}.", x, y, calc.Multiply(x, y));
            Console.WriteLine("The quotient of {0} and {1} is {2}.", x, y, calc.Divide(x, y));

            Console.Read();
        }
    }
}