using System;

namespace consoleapplication1
{
    ///<summary>
    /// Access Modifiers
    ///</summary>

    class Parent
    {
        public static int x = 10;
        protected static int y = 12;
        private static int z = 25;

        public static void Print()
        {
            Console.WriteLine(z);
        }
    }

    class Child : Parent
    {
        public static void Print()
        {
            Console.WriteLine(y);
        }
    }

    class NotConnected
    {
        public static void Print()
        {
            Console.WriteLine(Parent.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent.Print();
            Child.Print();
            NotConnected.Print();
            Console.Read();
        }
    }
}