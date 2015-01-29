
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace consoleapplication1
{
    // Multi-cast Delegates

    // A delegate is a method wrapper
    delegate void D(int x);

    class Program
    {
        public void Square(int i)
        {
            Console.WriteLine("{0} squared is {1}", i, i*i);
        }

        public void Cube(int i)
        {
            Console.WriteLine("{0} cubed is {1}", i, i * i * i);
        }

        static void Main(string[] args)
        {
            Program newprog = new Program();
            D del1, del2, del3;
            del1 = newprog.Square;
            del2 = newprog.Cube;
            del3 = del1 + del2;
            del3(4);

            Console.Read();
        }
    }
}