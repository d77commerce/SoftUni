using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] marix = new int[n, n];
            int result1 = 0;
            int result2 = 0;
            for (int i = 0; i < n; i++)
            {
                int[] vs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    marix[i, j] = vs[j];
                    if (i == j)
                    {
                        result1 += marix[i, j];
                    }
                }
            }
            int cout = n - 1;
            for (int i = 0; i < n; i++)
            {
                result2 += marix[i, cout];
                cout--;
            }
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(Math.Abs(result1-result2));
        }
    }
}
