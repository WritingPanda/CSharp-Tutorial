using System;

namespace consoleapplication1
{
    ///<summary>
    /// Create a program that contiually
    /// waits for user input
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose color: (B)lue or (R)ed.");
            string color = Console.ReadLine();
            string upperColor = color.ToUpper();
            if (upperColor == "B")
            {
                Console.ForegroundColor = System.ConsoleColor.Cyan;
            }
            if (upperColor == "R")
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            Console.WriteLine("Enter value whose absolute value you wish to find.");
            Console.WriteLine("Enter 0 to exit");
            double x = double.Parse(Console.ReadLine());
            while (x != 0)
            {
                Console.WriteLine("The absolute value of your number is {0}.", Math.Abs(x));
                Console.WriteLine("Enter value whose absolute value you wish to find.");
                x = double.Parse(Console.ReadLine());
            }
        }
    }
}