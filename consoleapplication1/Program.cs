using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Equality by references

    class Person
    {
        public string firstName;
        public string lastName;

        public Person(string fname, string lname)
        {
            Console.WriteLine("My name is {0} {1}.", this.firstName = fname, this.lastName = lname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person pr1 = new Person("Omar", "Quimbaya");
            Console.WriteLine("The person's name is {0} {1}.", pr1.firstName, pr1.lastName);

            // Points to the same reference in memory, so if one is changed, they are both changed.
            Person pr2 = pr1;
            
            Console.WriteLine("It is {0} that pr1 and pr2 are the same.", pr1 == pr2);

            // This changes both pr1 and pr2 since they both point to the same place in memory.
            pr2.firstName = "Becky";

            // This is true.
            Console.WriteLine("It is {0} that pr1 and pr2 are the same.", pr1 == pr2);

            // Both of these say "Becky Quimbaya"
            Console.WriteLine("The person's name is {0} {1}.", pr1.firstName, pr1.lastName);
            Console.WriteLine("The person's name is {0} {1}.", pr2.firstName, pr2.lastName);
            
            Console.Read();
        }
    }
}