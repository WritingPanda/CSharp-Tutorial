using System;

namespace consoleapplication1
{
    /// <summary>
    /// Extracting Methods and Organizing Using Statements
    /// </summary>
    class Program
    {
        public static void Display()
        {
            Display2();
        }

        private static void Display2()
        {
            Console.WriteLine("This is coming from function Display().");
        }

        static void Main(string[] args)
        {
            Display();
            Console.Read();
        }
    }
}