using System;
using System.IO;

namespace consoleapplication1
{
    /// <summary>
    /// Using the Using Statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("log.txt"))
            {
                writer.WriteLine(Console.ReadLine());
            }

            using (TextReader reader = File.OpenText("log.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.Read();
        }
    }
}