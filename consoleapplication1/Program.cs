using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Setting up a simple inheritance example

    class quad
    {
        public quad() // this will be our parent class
        {
            Console.WriteLine("I've got four sides!");
        }
    }

    class rectangle : quad // inheriting from the quad class
    {
        // parent quad class' constructor is used since rectangle does not have a constructor of its own
        public double Area( double x, double y )
        {
            return x * y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            rectangle myRect = new rectangle();
            double l = 12; double w = 13;
            Console.WriteLine("This area of our rectangle is {0}.", myRect.Area(l, w));
            Console.Read();
        }
    }
}