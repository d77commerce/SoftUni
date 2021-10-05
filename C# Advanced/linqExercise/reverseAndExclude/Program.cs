using System;
using System.Collections.Generic;
using System.Linq;

namespace reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int powerNum = int.Parse(Console.ReadLine());
            caculate(input, powerNum);
        }
        static void caculate(int[] numbers, int powernum)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % powernum != 0)
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result).Reverse().ToArray());
        }
    }
}
