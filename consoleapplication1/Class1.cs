using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    class Class1
    {
        private static int x = 5;
        private int y;

        public Class1(int z)
        {
            this.y = z;
        }

        public static int GetValue()
        {
            return Class1.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
