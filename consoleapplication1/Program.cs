using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace consoleapplication1
{
    // Creating and using virtual methods
    // Override the virtual class because child classes might need some type of 
    // customization.
    class Quad // represent four sided shapes in general
    {
        public Quad()
        {
            Console.WriteLine("I'm a quad!");
        }

        public virtual int Perimeter(int width, int length)
        {
            return (2 * width) + (2 * length);
        }
    }

    class Square : Quad // class Square inherits from class Quad
    {
        public override int Perimeter(int width, int length)
        {
            return 4 * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square();

            int w = 8;
            int l = 8;

            Console.WriteLine("The perimeter of our shape is {0}", mySquare.Perimeter(w, l));
            Console.Read();
        } 
    }
}