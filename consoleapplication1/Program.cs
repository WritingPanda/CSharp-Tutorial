using System;
using System.Diagnostics;

namespace consoleapplication1
{
    ///<summary>
    /// Destructors
    /// Used to destruct instances of classes.
    /// Can only be used with classes.
    /// Cannot be inherited or overloaded.
    /// Cannot be called. Invoked automatically.
    /// Does not take modifiers or have parameters.
    ///</summary>

    class Sample
    {
        private Stopwatch timer;

        public Sample()
        {
            timer = Stopwatch.StartNew();
            Console.WriteLine("This code runs when the object is constructed.");
        }

        public void HowLong()
        {
            Console.WriteLine("{0} has lived for {1}.", this, timer.Elapsed);
            Console.Read();
        }

        ~Sample()
        {
            HowLong();
            Console.WriteLine("This code runs when the object is destroyed.");
            Console.Read();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample samp = new Sample();
            Console.Read();
        }
    }
}