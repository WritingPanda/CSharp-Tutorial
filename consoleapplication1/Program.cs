using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapplication1
{
    // Multidimensional Arrays (Matrix)
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2]; // Declare and initialize a multidimensional array of size 2 by 2. This means 4 cells ( 0, 1 by 0, 1 )

            for (int i = 0; i < matrix.GetLength(0); i++) // Controls row index, meaning moves vertically down the matrix.
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Controls column index, meaning moves horizontally across the matrix
                {
                    matrix[i, j] = 1 + j;
                }
            }
        }
    }
}

// What this looks like
// [0, 0] [0, 1]
// [1, 0] [1, 1]
