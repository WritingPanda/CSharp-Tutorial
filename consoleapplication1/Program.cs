using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Create a simple class, add a constructor, and add one method

    class calculator // Declare a class
    {
        public calculator() // The constructor of the class (it is also the same name of the class)
        {
            Console.WriteLine("This will run when the object constructor is executed.");
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            calculator calc; // Declares an object of type calculator (reserve memory location)
            calc = new calculator(); // Initializes the calcular object (save to memory location)
            // calculator calc = new calculator(); <--- one liner

            Console.WriteLine("The sum of the two numbers is: {0}.", calc.Add(1, 4));

            Console.Read();
        }
    }
}