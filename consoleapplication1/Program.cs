using System;

namespace consoleapplication1
{
    /// <summary>
    /// Using Lambda Expressions with Outer Variables
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
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Func<int, int, int> myFunc1 = (int a, int b) => (a + b);
            Func<int, int, int> myFunc2 = (int a, int b) => (a - b);
            Console.WriteLine("The sum of {0} and {1} is {2}.", x, y, myFunc1(x, y));
            Console.WriteLine("The difference of {0} and {1} is {2}.", x, y, myFunc2(x, y));
            Console.Read();
        }
    }
}