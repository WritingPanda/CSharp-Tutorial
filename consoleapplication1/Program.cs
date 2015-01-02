using System;
using System.Collections.Generic;

namespace consoleapplication1
{
    // Polymorphism

    public class Shape
    {
        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks.");
        }
    }

    class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("I am a circle.");
        }
    }

    class Square : Shape
    {
        public Square()
        {
            Console.WriteLine("I am a square.");
        }

        public override void Draw()
        {
            // Code to draw a circle
            Console.WriteLine("Drawing a square.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism at work #1: a Rectangle, Triangle, and Circle
            // can all be used wherever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class. Each circle and square object is
            // treated as a shape, also. So it has two forms, polymorphism in action.
            List<Shape> newShapes = new List<Shape>();
            newShapes.Add(new Circle()); // expects the Shape object but gets a circle
            newShapes.Add(new Square()); // expects the Shape object but gets a square

            // Polymorphism at work #2: the virtual method Draw() is
            // invoked on each of the derived classes, not the base class.

            foreach (Shape shape in newShapes)
            {
                shape.Draw(); // runtime polymorphism. Expects to call base class draw but invokes derived class method
            }
            Console.WriteLine("Press any key to exit.");
            Console.Read();

            // You create a class of type Vehicle. You then create three subclasses called Sedan, Truck, and Minivan. 
            // Each of these can be added to a collection containing Vehicles. This is so because each is a kind of Vehicle, 
            // and therefore polymorphism applies.
        }
    }
}