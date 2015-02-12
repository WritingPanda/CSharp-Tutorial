using System;

namespace consoleapplication1
{
    /// <summary>
    /// Generic Interface with One Class
    /// </summary>

    class GenericClassUser
    {
        static void Main(string[] args)
        {
            InterfaceUser<int> mygen1 = new InterfaceUser<int>();
            mygen1.Show();

            InterfaceUser<string> mygen2 = new InterfaceUser<string>();
            mygen2.Show();

            Console.Read();
        }
    }
}