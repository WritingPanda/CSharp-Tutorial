using System;

namespace consoleapplication1
{
    ///<summary>
    /// Handling Multiple Exceptions
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter top");
                int top = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bottom");
                int bottom = Int32.Parse(Console.ReadLine());
                int quot = top/bottom;
                Console.WriteLine(quot);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.Read();
        }
    }
}