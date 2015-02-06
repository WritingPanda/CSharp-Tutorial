using System;
using System.IO;

namespace consoleapplication1
{
    ///<summary>
    /// Writing and reading files
    ///</summary>

    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "C:\\Users\\Omar\\Desktop\\sample.txt";
            TextWriter tw = new StreamWriter(filename);
            // Will read from the console window and save to the file
            tw.Write(Console.ReadLine());
            tw.Close();

            TextReader tr = new StreamReader(filename);
            // Will read from the file and display to the output window
            Console.WriteLine(tr.ReadLine());
            tr.Close();

            Console.Read();
        }
    }
}