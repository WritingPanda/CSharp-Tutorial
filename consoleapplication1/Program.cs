using System;

namespace consoleapplication1
{
    ///<summary>
    /// Try Catch Finally Construct
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            object o = "hello";

            try
            {
                i = (int) o; // tries to convert an object into an integer
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This code runs no matter what happens above.");
            }

            Console.Read();
        }
    }
}