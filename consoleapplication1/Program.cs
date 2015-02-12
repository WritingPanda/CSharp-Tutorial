using System;
using System.Collections.Generic;

namespace consoleapplication1
{
    /// <summary>
    /// List<T> with a user defined type
    /// </summary>
    
    public class Car
    {
        private readonly int _price;

        public Car(int p)
        {
            this._price = p;
        }

        public int GetPrice()
        {
            return this._price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> mycarlist = new List<Car>(3);
            for (int i = 0; i < 3; i++)
            {
                mycarlist.Add(new Car(10000 * i));
            }

            foreach (Car c in mycarlist)
            {
                Console.WriteLine("The price of the car is {0}.", c.GetPrice());
            }

            Console.Read();
        }
    }
}