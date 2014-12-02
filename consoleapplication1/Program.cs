using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Passing arrays as function arguments
    // When arrays are passed in a function, the data is not copied. The reference to the array is used instead.
    class ArrayPrinter
    {
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + 1; // Take each value and add one to the index
                Console.WriteLine("The value at index {0} is {1}.", i, array[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ArrayPrinter.printArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The value at index {0} is {1}.", i, arr[i]);
            }
            
            Console.Read();
        }
    }
}