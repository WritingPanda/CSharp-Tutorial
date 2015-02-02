using System;
using System.Security.Cryptography.X509Certificates;

namespace consoleapplication1
{
    ///<summary>
    /// Throwing and Catching Exceptions
    ///</summary>

    class Program
    {
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x/y;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter numerator: ");

                int top = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter denominator: ");
                int bottom = Int32.Parse(Console.ReadLine());

                Console.WriteLine(Divide(top, bottom));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
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