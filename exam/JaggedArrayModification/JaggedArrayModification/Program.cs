using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = input;
            }
            string[] act = Console.ReadLine().Split();
            while (act[0] != "END")
            {
                int row = int.Parse(act[1]);
                int col = int.Parse(act[2]);
                int val = int.Parse(act[3]);
                if (row >= 0 && row < jagged.Length &&
                    col >= 0 && col < jagged[row].Length)
                {
                    if (act[0] == "Add")
                    {
                        jagged[row][col] += val;
                    }
                    else if (act[0] == "Subtract")
                    {
                        jagged[row][col] -= val;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                act = Console.ReadLine().Split();
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }


        }
    }
}
