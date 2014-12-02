using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Using out parameters to return multiple values from functions
    // The out keyword causes arguments to be passed by reference.
    // This is like the ref keyword, except that ref requires that the variable be intialized BEFORE it is passed.
    // To use an out parameter, both the method definition and the calling method must explicitly use the out keyword.
    class test
    {
        public int outSample(out string first, out string second, int x, int y)
        {
            first = "Now I know how to add.";
            second = "Now I know how to add again!";
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            test testObj = new test();

            string first;
            string second;
            Console.WriteLine("The sum of 1 and 2 is {0}.", testObj.outSample(out first, out second, 1, 2));
            Console.WriteLine(first + " " + second);
            Console.Read();
        }
    }
}

// You can use the out contextual keyword in two contexts, as a parameter modifier or in generic type parameter declarations in interfaces and delegates. 
