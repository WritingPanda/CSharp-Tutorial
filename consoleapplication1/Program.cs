using System;

namespace consoleapplication1
{
    ///<summary>
    /// Interface
    /// An interface contains only the signatures of methods, 
    /// properties, events or indexers. A class or struct that 
    /// implements the interface must implement the members of 
    /// the interface that are specified in the interface definition.
    ///</summary>

    interface ICanBeUsedAsAChair
    {
        void SittingMessage();
    }

    class MilkCrate : ICanBeUsedAsAChair
    {
        public MilkCrate()
        {
            Console.WriteLine("I'm a milk crate.");
        }

        public void SittingMessage()
        {
            Console.WriteLine("I'm a crate being used as a chair.");
        }
    }

    class Program
    {
        public static void CanSitOn(ICanBeUsedAsAChair fakeChair)
        {
            fakeChair.SittingMessage();
        }
  
        static void Main(string[] args)
        {
            MilkCrate milkCrate = new MilkCrate();
            CanSitOn(milkCrate);
            Console.Read();
        }
    }
}