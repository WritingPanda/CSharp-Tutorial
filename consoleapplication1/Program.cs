using System;

namespace consoleapplication1
{
    /// <summary>
    /// Arrays of Pointers
    /// </summary>
    class Program
    {
        unsafe static void Main(string[] args)
        {
            // An array of memory addresses
            int*[] arr = new int*[3];
            int x = 10;
            int y = 11;
            int z = 12;
            arr[0] = &x;
            arr[1] = &y;
            arr[2] = &z;

            for (int i = 0; i < arr.Length; i++)
            {
                // assigns new values to the variables
                *arr[i] = i*i + 1;
            }

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Read();
        }
    }
}