using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    class Program
    {

        // Using the ref modifier in function calls
        // Using ref as the keyword in a function header allows treating basic types as if they were reference types
        // Changing the value in the one function means that change is visible in other functions immediately
        static void SampMethod(ref int i)
        {
            i = i * 8;
        }

        static void Main(string[] args)
        {
            int x = 9;
            SampMethod(ref x);
            Console.WriteLine("The value of x is {0}.", x);
            Console.ReadKey();
        }
    }
}
