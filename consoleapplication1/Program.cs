using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Class level fields sharing between among objects

    class Program
    {
        static void Main(string[] args)
        {
            Class1 myObj1 = new Class1(7);
            Class1 myObj2 = new Class1(8);

            Console.WriteLine("This instance variable is {0}.", myObj1.GetY());
            Console.WriteLine("This instance variable is {0}.", myObj2.GetY());
            Console.WriteLine("The value of the static instance variable is {0}.", Class1.GetValue());

            Console.Read();
        }
    }
}