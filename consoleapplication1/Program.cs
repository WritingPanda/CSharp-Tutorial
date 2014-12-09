using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // "Is a" relationships in object oriented programming

    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("I can take you places!");
        }
    }

    class RaceCar : Vehicle // racecar is a kind of vehicle
    {
        public RaceCar() 
            : base() // call the base class constructor 
        {
            Console.WriteLine("I can take you places very fast.");
        }
    }

    class MiniVan : Vehicle // minivan is a kind of vehicle
    {
        public MiniVan()
            : base()
        {
            Console.WriteLine("I can take you places along with many others!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RaceCar newRaceCar = new RaceCar();
            MiniVan myMiniVan = new MiniVan();
            Console.Read();
        }
    }
}