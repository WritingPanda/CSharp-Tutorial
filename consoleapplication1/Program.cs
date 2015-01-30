using System;

namespace consoleapplication1
{
    ///<summary>
    /// Partial Class
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee("Omar");
            Console.WriteLine("The name of the person is {0}.", newEmployee.GetFirst());
            Console.Read();
        }
    }
}