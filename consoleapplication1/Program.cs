using System;

namespace consoleapplication1
{
    // Actions
    // Encapsulates a method that has a single parameter
    // and does not return a value

    class Program
    {
        private static void showCube(dynamic i)
        {
            Console.WriteLine("The cube of {0} is {1}.", i, i*i*i);
        }
        static void Main(string[] args)
        {
            Action<dynamic> cubeIt = showCube;

            dynamic x = double.Parse(Console.ReadLine());
            cubeIt(x);

            x = int.Parse(Console.ReadLine());
            cubeIt(x);

            x = decimal.Parse(Console.ReadLine());
            cubeIt(x);

            Console.Read();
        }
    }
}