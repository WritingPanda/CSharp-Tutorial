using System;

namespace consoleapplication1
{
    /// <summary>
    /// Intro to Generics
    /// Generics let you tailor a method, class, structure, 
    /// or interface to the precise data type it acts upon.
    /// Among the benefits of generics are increased code 
    /// reusability and type safety.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // 
            Generics<int> myGenerics1 = new Generics<int>(5);
            int y1 = myGenerics1.Get();
            Console.WriteLine("The value of y1 is {0}.", y1);

            Generics<string> myGenerics2 = new Generics<string>("Hello world");
            string y2 = myGenerics2.Get();
            Console.WriteLine("The value of y2 is {0}.", y2);
            Console.Read();
        }
    }
}