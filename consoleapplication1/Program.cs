using System;
using System.Collections.Generic;

namespace consoleapplication1
{
    // Create a list of objects and step through it using a foreach loop

    class Person
    {
        public string name;

        public Person(string s)
        {
            this.name = s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> newPersonList = new List<Person>();

            // Invoking the constructor of the class
            newPersonList.Add(new Person("Becky"));
            newPersonList.Add(new Person("Omar"));
            newPersonList.Add(new Person("Illiana"));
            newPersonList.Add(new Person("Illiam"));
            newPersonList.Add(new Person("Daniel"));
            newPersonList.Add(new Person("Celia"));

            foreach (Person per in newPersonList)
            {
                Console.WriteLine("The person's name is " + per.name);
            }

            Console.Read();
        } 
    }
}