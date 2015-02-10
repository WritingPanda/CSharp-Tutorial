using System;
using System.Diagnostics;

namespace consoleapplication1
{
    /// <summary>
    /// Conditional Methods
    /// </summary>

    public class Trace
    {
        // Works only when the program is running in DEBUG mode
        [Conditional("DEBUG")]
        public static void Message(string traceMessage)
        {
            Console.WriteLine("[TRACE] - " + traceMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trace.Message("Main starting");
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments have been passed.");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Arg[{0}] is [{1}].", i, args[i]);
                }
            }

            Trace.Message("Main ending");
            Console.Read();
        }
    }
}