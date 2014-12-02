using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Enumerations
    // The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.
    // Usually, it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. 
    // However, an enum can also be nested within a class or a struct.
    // By default, the first enumerator has the value of 0, and the value of each successive enumerator is increased by 1.

    // In this example, we are using Sunday to be the first day of the week, so we change its value to 1.

    // Approved types for an enum are byte, sbyte, short, ushort, int, uint, long, and ulong.

    enum Days
    {
        // An enumerator cannot contain white space in its name.
        Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    };

    enum intMaxMin : int
    {
        max = int.MaxValue, min = int.MinValue
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sunday is the {0}st day of the week.", (int)Days.Sunday);
            // An explicit cast is necessary to convert from enum type to an integral type.
            Console.WriteLine("The maximum value of the integer data type is {0:N0} and the minimum value is {1:N0}.", (int)intMaxMin.max, (int)intMaxMin.min);

            Console.Read();
        }
    }
}

// Output

// Sunday is the 1st day of the week.
// The maximum value of the integer data type is 2,147,483,647 and the minimum value is -2,147,483,648.