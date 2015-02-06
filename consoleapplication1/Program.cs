using System;

namespace consoleapplication1
{
    ///<summary>
    /// Memberwise Clone, Shallow Copies and Deep copies
    /// Shallow Copy: reference is copied
    /// Deep copy: object is copied
    ///</summary>

    public class SSN
    {
        public string social;
        public SSN(string ss)
        {
            social = ss;
        }
    }

    class Person
    {
        public string fname;
        public SSN newssn;

        public Person(string first, string socialnumber)
        {
            fname = first;
            newssn = new SSN(socialnumber);
        }

        public Person Copy()
        {
            // Clones the current person object and return a shallow copy of the person object
            // It copies the object by reference
            return (Person) this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("John", "1234");
            Console.WriteLine("The name is " + per1.fname + " and the ssn is " + per1.newssn.social);

            Person per2 = per1.Copy();
            Console.WriteLine("The name is " + per2.fname + " and the ssn is " + per2.newssn.social);
            per2.newssn.social = "5678";
            // the new ssn is also reflected in the data for per1
            // simple data types like integers are copied bit by bit
            // however, object types are copied by reference
            // so changing one object changes other objects -- Shallow Copy
            Console.WriteLine("The name is " + per1.fname + " and the ssn is " + per1.newssn.social);
            Console.WriteLine("The name is " + per2.fname + " and the ssn is " + per2.newssn.social);
            Console.Read();
        }
    }
}