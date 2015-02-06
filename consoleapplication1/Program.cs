using System;

namespace consoleapplication1
{
    ///<summary>
    /// The ToString Function
    /// Returns a string that represents the current object
    ///</summary>

    class Person
    {
        public Person()
        {
            Console.WriteLine("I'm a person object.");
        }
    }

    class Boss : Person
    {
        public Boss()
        {
            Console.WriteLine("I'm a boss man.");
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Person().ToString());
            Console.WriteLine(new Boss().ToString());
            Console.WriteLine(5.ToString());
            Console.Read();
        }
    }
}