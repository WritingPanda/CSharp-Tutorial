using System;
using System.Runtime.CompilerServices;

namespace consoleapplication1
{
    /// <summary>
    /// Funcs with Dynamic Variables
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

            Func<dynamic, dynamic, int, dynamic> divide = (a, b, round) => Math.Round(a/b, round);
            Func<dynamic, dynamic, int, dynamic> multiply = (a, b, round) => Math.Round(a*b, round);

            dynamic x = divide(5.56, 6.789, 4);
            dynamic y = multiply(5.56, 6.789, 4);

            Console.WriteLine(x); Console.WriteLine(y);

            Console.Read();
        }
    }
}