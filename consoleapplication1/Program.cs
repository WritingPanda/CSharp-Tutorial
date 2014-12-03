using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // User defined data type

    class Person
    {
        private string ssn; // We are the ones who created this particular class with these properties
        private int bankBalance;
        public string name;

        public Person(string social, int bankBal, string fullName)
        {
            this.ssn = social;
            this.bankBalance = bankBal;
            this.name = fullName;
        }
    }

    class Program
    {
        static void Main(string[] args) // the method stays in memory the entire time
        {
            int x = 5;

            Person per1 = new Person("456-54-345", 100000, "Diego Dog"); // user defined data type object
        }
    }
}