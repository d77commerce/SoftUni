using System;
using System.Linq;
using System.Collections.Concurrent;

namespace appliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int[], int[]> add = num =>
            {
                for (int i = 0; i < num.Length; i++)

                {
                    num[i]++;
                }
                return num;
            };
            Func<int[], int[]> multiply = num =>
            {
                for (int i = 0; i < num.Length; i++)

                {
                    num[i] *= 2;
                }
                return num;
            };
            Func<int[], int[]> subtract = num =>
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i]--;
                }
                return num;
            };
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                else if (comand == "add")
                {
                    add(input);
                }
                else if (comand == "multiply")
                {
                    multiply(input);
                }
                else if (comand == "subtract")
                {
                    subtract(input);
                }
                else if (comand == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }

            }
        }
    }
}
