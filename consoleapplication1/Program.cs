
using System;

namespace consoleapplication1
{
    // Overloading Operators 2
    
    class Program
    {
        class PerimFinder
        {
            private int lengthOfSide;
            private int numberOfSides;

            public PerimFinder(int length, int n)
            {
                this.lengthOfSide = length;
                this.numberOfSides = n;
            }

            public static int operator +(PerimFinder s1, PerimFinder s2)
            {
                return s1.numberOfSides*s1.lengthOfSide + s2.lengthOfSide*s2.numberOfSides;
            }
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            int x;
            int y;
            int xNumberOfSides;
            int yNumberOfSides;

            do
            {
                Console.WriteLine("Enter the first side length: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of sides for this shape: ");
                xNumberOfSides = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the first side length: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of sides for this shape: ");
                yNumberOfSides = int.Parse(Console.ReadLine());

                PerimFinder newPerim1 = new PerimFinder(x, xNumberOfSides);
                PerimFinder newPerim2 = new PerimFinder(y, yNumberOfSides);
                Console.WriteLine(newPerim1 + newPerim2);

                // Console Key, a way to capture key input and do something with it
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }
    }
}