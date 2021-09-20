using System;
using System.Linq;

namespace _03primaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            int sum = 0;
            for (int row = 0; row < matrixSize; row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int count = 0;
            while(count<matrixSize)
            {
                sum += matrix[count, count];
                count++;
            }
            Console.WriteLine(sum);
        }
    }
}
