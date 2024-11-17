using System;
using System.Diagnostics;

namespace Ex1_MatrixMultiplication
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] array2 = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[,] newArray = new int[2, 2];

            newArray[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
            newArray[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
            newArray[0, 1] = array1[0, 0] * array2[1, 1] + array1[0, 1] * array2[1, 1];
            newArray[1, 1] = array2[1, 0] * array2[0, 1] + array2[1, 1] * array2[1, 1];

            for (int i = 0; i < newArray.GetLength(0); i++)
                for (int j = 0; j < newArray.GetLength(1); j++)
                    Console.WriteLine(newArray[i, j]);
        }
    }
}
