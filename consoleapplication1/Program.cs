
using System;

namespace consoleapplication1
{
    // Overloading Operators
    
    class Program
    {
        private string whatever;

        public Program(string s)
        {
            this.whatever = s;
        }

        // The + in the Console.Writeline() is the operator that we are overloading.
        // So, when the code runs, it adds the additional text at the end of the strings.
        // In this program, + now means concatenating the two Program objects along with an additional string.
        public static Program operator +(Program s1, Program s2)
        {
            return new Program(s1.whatever + s2.whatever + " Oh yeah!");
        }

        public override string ToString()
        {
            return this.whatever;
        }

        static void Main(string[] args)
        {
            Program newprog1 = new Program("Hello, ");
            Program newprog2 = new Program("World!");
            Console.WriteLine((newprog1 + newprog2).ToString());
            Console.ReadLine();
        }
    }
}