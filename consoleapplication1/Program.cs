using System;

namespace consoleapplication1
{
    /// <summary>
    /// Lambda Expressions that Change Local Variables
    /// A lambda expression is an anonymous function 
    /// that you can use to create delegates or expression tree types.
    /// By using lambda expressions, you can write local functions 
    /// that can be passed as arguments or returned as the value of 
    /// function calls. Lambda expressions are particularly helpful 
    /// for writing LINQ query expressions.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Func<double> myFunc1 = () => ++x;
            Func<double, double> myFunc2 = (a) => (a*a);

            Console.WriteLine("The value of {0} squared is {1}.", myFunc1(), myFunc2(x));
            Console.Read();
        }
    }
}