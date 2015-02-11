using System;
using System.Collections.Generic;

namespace consoleapplication1
{
    /// <summary>
    /// List<T> with predefined types
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            List<int> myItems = new List<int>(5);
            for (int i = 0; i < 5; i++)
            {
                myItems.Add(i);
            }

            foreach (int d in myItems)
            {
                Console.WriteLine("The value stored is {0}.", d);
            }

            Console.WriteLine("The maximum length of the list is {0}.", myItems.Capacity);
            Console.WriteLine("The number of items actually stored is {0}.", myItems.Count);
            Console.Read();
        }
    }
}