using System;

namespace consoleapplication1
{
    ///<summary>
    /// Objects into Arrays with Indexers
    /// Indexer takes an object and turns it into an array
    ///</summary>

    class IndexerExample
    {
        private readonly float[] _myarray = new float[3] { 3.4F, 5.6F, 8.9F };

        // header of indexer. Returns a float and accepts an integer
        // the float is the value from the array above, and the integer is the index in the array
        public float this[int i]
        {
            // returns a value from the array above
            get { return _myarray[i]; }
            // sets a value inside the array
            set { _myarray[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IndexerExample myExample = new IndexerExample();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The index {0} stores the value: {1}", i, myExample[i]);
            }

            Console.WriteLine("The first index stores the value: {0}", myExample[0]);
            Console.WriteLine("The second index stores the value: {0}", myExample[1]);
            Console.WriteLine("The third index stores the value: {0}", myExample[2]);
            Console.Read();
        }
    }
}