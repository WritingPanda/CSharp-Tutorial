
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace consoleapplication1
{
    // Delegates
    /// <summary>
    /// A delegate is a type that represents references to methods with a 
    /// particular parameter list and return type. When you instantiate a 
    /// delegate, you can associate its instance with any method with a 
    /// compatible signature and return type. You can invoke (or call) 
    /// the method through the delegate instance. Delegates are used to 
    /// pass methods as arguments to other methods. Event handlers are 
    /// nothing more than methods that are invoked through delegates. 
    /// You create a custom method, and a class such as a windows 
    /// control can call your method when a certain event occurs. 
    /// </summary>

    internal delegate void D(int x);

    class Program
    {
        public void SampFunc1(int i)
        {
            Console.WriteLine("{0} squared is {1}", i, i * i);
        }

        public void SampFunc2(int i)
        {
            Console.WriteLine("{0} cubed is {1}", i, i*i*i);
        }
        static void Main(string[] args)
        {
            Program newprog = new Program();

            D newDel1, newDel2, newDel3;
            newDel1 = newprog.SampFunc1;
            newDel2 = newprog.SampFunc2;
            // Calls both functions
            newDel3 = newDel1 + newDel2;
            newDel3(4);
            Console.Read();
        }
    }
}