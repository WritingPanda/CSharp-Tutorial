using System;
using System.Diagnostics;

namespace consoleapplication1
{
    ///<summary>
    /// String Functions
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is an example of a string that spans " +
                         "multiple lines.";
            Console.WriteLine("The string is {0}.", str);

            // Get the character at the index of 1
            string part = str.Substring(1, 5);
            Console.WriteLine(part);

            // Determine whether the string begins with string "This"
            Console.WriteLine("The string starts with 'This': {0},", str.StartsWith("This"));

            // Find out the first instance of the letter i and what index it is located
            Console.WriteLine("The first letter i is at {0}.", str.IndexOf("i"));

            Console.Read();
        }
    }
}