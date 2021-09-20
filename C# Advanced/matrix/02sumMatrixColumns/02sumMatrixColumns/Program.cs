using System;
using System.Linq;

namespace _02sumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int ColSum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j <matrix.GetLength(0) ; j++)
                {
                    ColSum += matrix[j, i];
                }
                Console.WriteLine(ColSum);
                ColSum = 0;
            }
        }
    }
}
