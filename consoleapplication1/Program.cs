using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Understanding the difference between class methods and object methods

    class Sample
    {
        public Sample()
        {
            Console.WriteLine("I'm the class constructor.");
        }

        public void objectMethod()
        {
            Console.WriteLine("Called using an instance of the class.");
        }

        public static void classMethod()
        {
            Console.WriteLine("Called on the class itself.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample samp = new Sample();
            samp.objectMethod();
            Sample.classMethod();
            Console.Read();
        }
    }
}