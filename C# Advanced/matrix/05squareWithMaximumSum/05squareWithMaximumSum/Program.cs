using System;
using System.Linq;

namespace _05squareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizematrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizematrix[0], sizematrix[1]];
            for (int row = 0; row < sizematrix[0]; row++)
            {
                var rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizematrix[1]; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int sum = int.MinValue;
            int[,] win = new int[2, 2];
            for (int i = 0; i < sizematrix[0] - 1; i++)
            {
                for (int j = 0; j < sizematrix[1]-1; j++)
                {
                    if (matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > sum)
                    {
                        sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                        win[0, 0] = matrix[i, j];
                        win[0, 1] = matrix[i, j+1];
                        win[1, 0] = matrix[i+1, j];
                        win[1, 1] = matrix[i+1, j+1];
                    }
                }
            }
            Console.WriteLine($"{win[0,0]} {win[0,1]}");
            Console.WriteLine($"{win[1,0]} {win[1,1]}");
            Console.WriteLine(sum);
        }
    }
}
