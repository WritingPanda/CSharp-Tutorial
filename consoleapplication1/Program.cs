using System;
//using System.Security.AccessControl;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace consoleapplication1
{
    // Understanding Upcasting

    class Person
    {
        private string _ssn;

        public Person(string social)
        {
            this._ssn = social; // the instance field ssn is assigned using the local variable social
        }
    }

    class Employer : Person
    {
        public Employer(string social) : base(social) // calls the constructor of the base class
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Employer("1231231313");
            Console.Read();
        } 
    }
}