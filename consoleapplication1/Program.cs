using System;

namespace consoleapplication1
{
    /// <summary>
    /// Returning Lambda Expression References from Functions
    /// A lambda expression is an anonymous function 
    /// that you can use to create delegates or expression tree types.
    /// By using lambda expressions, you can write local functions 
    /// that can be passed as arguments or returned as the value of 
    /// function calls. Lambda expressions are particularly helpful 
    /// for writing LINQ query expressions.
    /// </summary>

    class Program
    {
        private static int myvar = 5;

        public static Func<int> Adder()
        {
            return () => ++myvar;
        }

        public static Func<int, int> Square()
        {
            return (int a) => (a*a);
        } 

        static void Main(string[] args)
        {

            Func<int> myFunc1 = Adder();
            Console.WriteLine(myFunc1());

            Func<int, int> myFunc2 = Square();
            Console.WriteLine(myFunc2(5));

            Console.Read();
        }
    }
}