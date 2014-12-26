using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Coding properties
    // Getters and setters

    class Person
    {
        private string name;
        private string ssn;
        
        // The keyword "value" MUST be used.
        public string Social
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string FullName
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.FullName = "John Smith";
            newPerson.Social = "456-82-0932";
            Console.WriteLine(newPerson.FullName + " has the social security number given by " + newPerson.Social);

            Console.Read();
        } 
    }
}