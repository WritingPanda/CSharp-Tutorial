using System;
//using System.Security.AccessControl;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace consoleapplication1
{
    // The purpose and coding of an abstract class

    abstract class Shape // stores behaviors that are common to child classes
    {
        public abstract int Area(); // Must be implemented in derived classes
        // code inheriting from this class must provide the code to define the Area()
    }

    class Rectangle : Shape // inherits from Shape class
    {
        private int sideLength;

        public Rectangle(int side)
        {
            this.sideLength = side;
        }

        public override int Area()
        {
            return this.sideLength*this.sideLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myRectangle = new Rectangle(10);
            Console.Read();
        } 
    }
}