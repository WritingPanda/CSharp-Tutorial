using System;

namespace consoleapplication1
{
    class InterfaceUser<T> : IGenericInterface<T>
    {
        public void Show()
        {
            Console.WriteLine("This code runs from the generic class.");
        }
    }
}
