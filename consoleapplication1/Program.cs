using System;
using System.Collections.Generic;

namespace consoleapplication1
{
    /// <summary>
    /// Undertanding Generic Dictionaries
    /// Key value pairs
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            Console.WriteLine("Enter the first value: ");
            myDictionary.Add("First", Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            myDictionary.Add("Second", Console.ReadLine());

            Console.WriteLine("The value stored first is {0}.", myDictionary["First"]);
            Console.WriteLine("The value stored second is {0}.", myDictionary["Second"]);

            Console.Read();
        }
    }
}