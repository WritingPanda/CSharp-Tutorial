using System;

namespace consoleapplication1
{
    // Structs

    class MyClass
    {
        public int x; // Reference type, good for composite and complex objects; passing references
    }

    struct MyStruct
    {
        public int x; // Value type, good for simple composite objects; passing copies of objects
    }

    class TestClass
    {
        public static void StructTaker(MyStruct s)
        {
            s.x = 5;
        }

        public static void ClassTaker(MyClass c)
        {
            c.x = 5;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct a = new MyStruct();
            MyClass b = new MyClass();
            a.x = 1;
            b.x = 1;
            TestClass.StructTaker(a);
            TestClass.ClassTaker(b);
            // A copy was passed into StructTaker() and changed, but the original '7a' does not change
            Console.WriteLine(a.x);
            // A reference was passed into ClassTaker() and changed
            Console.WriteLine(b.x);
            Console.Read();
        }
    }
}