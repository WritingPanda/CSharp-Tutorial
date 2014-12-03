using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Instance variables with two objects
    class Person
    {
        public string personName;
        public string ssn;

        public Person(string fullName, string social)
        {
            this.personName = fullName;
            this.ssn = social;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("Omar Quimbaya", "555-55-5555");
            Person per2 = new Person("Becky Liu", "444-55-7777");

            Console.WriteLine(per1.personName);
            Console.WriteLine(per2.personName);

            Console.Read();
        }
    }
}