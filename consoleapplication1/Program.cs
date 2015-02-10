using System;
using System.IO;

namespace consoleapplication1
{
    /// <summary>
    /// Display files and folders in a directory
    /// </summary>

    

    class Program
    {
        static void Main(string[] args)
        {
            // Use @ in front of a string to avoid using escape characters
            string[] files = Directory.GetFiles(@"C:\Users\Omar\Documents\data");
            string[] folders = Directory.GetDirectories(@"C:\Users\Omar\Documents");

            foreach (string f in files)
            {
                Console.WriteLine("The file called {0} is located in {1}.", Path.GetFileName(f), Path.GetDirectoryName(f));
            }

            foreach (string f in folders)
            {
                Console.WriteLine("The directory is {0}.", f.ToString());
            }

            Console.Read();
        }
    }
}