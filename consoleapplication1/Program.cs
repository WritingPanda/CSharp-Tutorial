using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Params keyword in function headers
    class Program
    {
        public static void paramExample(int c, params object[] x) // params must be the final parameter in the list
        {
            Console.WriteLine(c);
            
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("The value stored at index {0} is {1}.", i, x[i]);
            }
        }

        static void Main(string[] args)
        {
            Program.paramExample(4, 1);
            Program.paramExample(1, "example", "A", 2.45644);

            Console.Read();
        }
    }
}

// Output:

// 4
// The value stored at index 0 is 1.
// 1
// The value stored at index 0 is example.
// The value stored at index 1 is A.
// The value stored at index 2 is 2.45644.