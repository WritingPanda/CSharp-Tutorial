using System;

namespace consoleapplication1
{
    /// <summary>
    /// Func<> Notation for Lambda Expressions
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Declare code of a type function
            Func<String> myFunc1 = () => "Hello world";
            Console.WriteLine("Func1 returns {0}.", myFunc1());

            // Three ints for two parameters and one return value
            Func<int, int, int> myFunc2 = (int a, int b) => (a + b);
            Console.WriteLine("The sum of 4 and 10 is {0}.", myFunc2(4, 10));

            Console.Read();
        }
    }
}