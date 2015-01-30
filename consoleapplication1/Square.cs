using System;

namespace consoleapplication1
{
    ///<summary>
    /// Interface Example 2
    ///</summary>

    class Square : Rectangle
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square();
            double sqrArea = mySquare.Area(5.6, 5.6);
            Console.WriteLine("Area is {0}", sqrArea);
            Console.Read();
        }
    }
}