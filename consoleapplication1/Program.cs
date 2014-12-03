using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // How to declare and access instance variables
    class Person
    {
        // Restricted access to these variables, only accessible in this class
        private string fullName; // Instance variable (or field)
        private int age;

        // Constructor and setter
        public Person(string personName, int personAge)
        {
            this.fullName = personName; // Sets the instance variable
            this.age = personAge;
        }

        // Getters
        public string getName()
        {
            return this.fullName; // this refers to the current object
        }

        public int getAge()
        {
            return this.age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("Omar Quimbaya", 28);

            Console.WriteLine(per1.getName() + " is " + per1.getAge());
            Console.Read();
        }
    }
}