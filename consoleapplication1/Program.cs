using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Dynamic Data Typing
    
    class Program
    {
        static void Main(string[] args)
        {
            // The dynamic keyword represents an object whose operations will be resolved at runtime
            dynamic x;

            x = 5;
            // x becomes an int
            Console.WriteLine(x);

            x = "hello";
            // x becomes a string
            Console.WriteLine(x);

            x = 'C';
            // x becomes a char
            Console.WriteLine(x);

            Console.Read();

            // Local variable x is a dynamic {int}, then a dynamic {string}, and then a dynamic {char}.
        }
    }
}