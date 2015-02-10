using System;
// Instead of typing this whole thing, I can use this syntax
using MathematicsLibrary.Arithmetic;

namespace consoleapplication1
{
    /// <summary>
    /// Fully Qualified Names
    /// </summary>

    

    class Program
    {
        static void Main(string[] args)
        {
            // Referencing a custom DLL 
            Console.WriteLine(AddingMachine.Add(1, 2, 3, 4, 5, 6.7));
            Console.Read();
        }
    }
}