using System;

namespace consoleapplication1
{
    /// <summary>
    /// Pointers and AddressOf Operator
    /// Pointers are references to data stored in memory
    /// </summary>
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int i = 4;
            // Gets the address of i and stores it in mynumb
            int* mynumb = &i;
            // Changes the value of i
            *mynumb = 135;
            Console.WriteLine(i);
            Console.Read();
        }
    }
}