using System;

namespace consoleapplication1
{
    /// <summary>
    /// Nullable Data Type
    /// </summary>

    

    class Program
    {
        static void Main(string[] args)
        {
            // Really used for working with databases
            // Can set variable to null instead of 0 or some other value
            // Works nice with databases
            int? x = null;

            if (x.HasValue)
            {
                Console.WriteLine("The value of x is {0}.", x);
            }
            else
            {
                Console.WriteLine("The value of x has been set to null.");
            }

            Console.Read();
        }
    }
}