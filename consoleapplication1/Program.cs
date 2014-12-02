using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{

    // Using the length property of arrays and converting between data types
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[5]; // declaring and reserving an array that stores doubles[5 of them] (numbers with decimals)

            for (int i = 0; i < myArray.Length; i++)
            {
                // Start from index zero in the array and loop until we are less than the length of the array
                
                myArray[i] = (double)i / (double)(i + 1); // This code converts the index variable to a double data type for mathematics.
                Console.WriteLine("The value of {0} divided by {1} is {2}.", i, i + 1, myArray[i]);
            }
            Console.Read();
        }
    }
}
