using System;

namespace consoleapplication1
{

    ///<summary>
    /// Events are a special kind of multicast delegate 
    /// that can only be invoked from within the class 
    /// or struct where they are declared (the publisher 
    /// class). If other classes or structs subscribe to 
    /// the event, their event handler methods will be 
    /// called when the publisher class raises the event.
    ///</summary>
    // Handling Simples Events Using Delegates
    public delegate void DoTheMath(int x, int y);

    class Program
    {
        public static event DoTheMath ops;

        public static void Add(int x, int y)
        {
            Console.WriteLine("The sum is {0}.", x + y);
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine("The difference is {0}.", x - y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first number is: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The second number is: ");
            int y = Int32.Parse(Console.ReadLine());

            ops = new DoTheMath(Add);

            // Chaining multiple methods to one delegate
            // Calls add first, then does subtract
            ops += new DoTheMath(Subtract);

            ops(x, y);

            Console.Read();
        }
    }
}