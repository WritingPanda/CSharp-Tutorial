using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Parameterized: you can pass different data types into the class
    class Generics<T>
    {
        private T x;

        public Generics(T val)
        {
            x = val;
        }

        public T Get()
        {
            return x;
        }
    }
}
