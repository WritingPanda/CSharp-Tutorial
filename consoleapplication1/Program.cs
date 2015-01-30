using System;

namespace consoleapplication1
{
    ///<summary>
    /// Error Checking with if/else
    ///</summary>

    class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("I'm a lazy calculator. I do only division.");
        }

        public double Divide(double x, double y)
        {
            if (y != 0) return x / y;

            Console.WriteLine("Whoa! WTF! You can't divide by 0!");
            return 0.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = 4;
            int y = 0;
            Console.WriteLine("The result of your division is: {0}.", calc.Divide(x, y));
            Console.Read();
        }
    }
}