using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Difference between dynamic and var
    
    class Program
    {
        static void Main(string[] args)
        {
            // Variables that are declared at method scope can have an IMPLICIT type var.
            // An implicitly typed local variable is strongly typed just as if you had declared the type yourself.
            // The compiler determines the type.
            // var i = 10; IMPLICITLY typed
            // int i = 10; EXPLICITLY typed
            var x = 5;
            var y = "Hello";

            // The type is a static type, but an object of type dynamic bypasses static type checking. 
            // In most cases, it functions like it has type object. 
            // At compile time, an element that is typed as dynamic is assumed to support any operation. 
            // Therefore, you do not have to be concerned about whether the object gets its value from a COM API, from a dynamic language such as IronPython, from the HTML Document Object Model (DOM), from reflection, or from somewhere else in the program. 
            // However, if the code is not valid, errors are caught at run time.
            dynamic z = x;
            Console.WriteLine(z);

            z = y;
            Console.WriteLine(z);

            Console.Read();
        }
    }
}