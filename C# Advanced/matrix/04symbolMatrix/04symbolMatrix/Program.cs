using System;

namespace _04symbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            var matrix = new int[sizeMatrix, sizeMatrix];
            for (int row = 0; row < sizeMatrix; row++)
            {
                var iputRow = Console.ReadLine();
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = iputRow[col];
                }
            }
            char simbol = char.Parse(Console.ReadLine());
            var hold = true;
            for (int row = 0; row < sizeMatrix; row++)
            {
                for (int col = 0; col < sizeMatrix; col++)
                {
                    if (simbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        hold = false;
                    }
                }
            }
            if (hold == true)
            {
                Console.WriteLine($"{simbol} does not occur in the matrix");
            }
        }
    }
}
