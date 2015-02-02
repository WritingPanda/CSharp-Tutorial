using System;

namespace consoleapplication1
{
    ///<summary>
    /// Object Equals and the Reference Equals Methods
    /// The Object class is the parent class of objects.
    /// Object.Equals: determines whether the specificed object is equal to the current object.
    /// ReferenceEquals: determines whether the object instances are the same instance.
    ///</summary>

    class Program
    {
        class Person
        {
            // Good practice to put an underline in front of private properties
            private string _fName;

            public Person(string name)
            {
                _fName = name;
            }
        }
        static void Main(string[] args)
        {
            Person per1 = new Person("Omar");
            Person per2 = per1;
            Person per3 = new Person("Omar");
            // True
            Console.WriteLine("per1 and per2 are the same: {0}.", per1.Equals(per2));
            // True
            Console.WriteLine("per1 and per2 are the same: {0}.", ReferenceEquals(per1, per2));
            // False
            Console.WriteLine("per1 and per3 are the same: {0}.", per1.Equals(per3));
            // False
            Console.WriteLine("per1 and per3 are the same: {0}", ReferenceEquals(per1, per3));
            Console.Read();
        }
    }
}