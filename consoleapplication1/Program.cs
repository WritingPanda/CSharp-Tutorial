using System;
// This is the DLL in a difference solution
// Had to change framework from 4.5 to 4.5.1 due to ArithmeticOps using the 4.5.1 .NET framework
using ArithmeticOps;

namespace consoleapplication1
{
    /// <summary>
    /// Create a Dynamic Link Library and Reference It
    /// </summary>

    

    class Program
    {
        static void Main(string[] args)
        {
            Calc myCalc = new Calc();
            Console.WriteLine("The sum of 1 and 2 is {0}.", myCalc.Add(1, 2));
            Console.WriteLine("The difference of 1 and 2 is {0}.", myCalc.Subtract(1, 2));
            Console.Read();
        }
    }
}