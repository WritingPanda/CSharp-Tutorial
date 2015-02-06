using System;

namespace consoleapplication1
{
    ///<summary>
    /// Get Type Method
    /// Gets the type of an object
    ///</summary>

    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Class 1 object.");
        }
    }

    public class Class2
    {
        public Class2()
        {
            Console.WriteLine("Class 2 object.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 klass1 = new Class1();
            Class2 klass2 = new Class2();
            Console.WriteLine(klass1.GetType());
            Console.WriteLine(klass2.GetType());
            Console.WriteLine(klass1.GetType() == klass2.GetType());
            Console.Read();
        }
    }
}