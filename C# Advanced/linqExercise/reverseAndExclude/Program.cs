using System;
using System.Collections.Generic;
using System.Linq;

namespace reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int powerNum = int.Parse(Console.ReadLine());
            caculate(input, powerNum);
        }
        static void caculate(List<int> numbers, int powernum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % powernum == 0)
                {
                    numbers.RemoveAt(i);
                }
            }
          
            Console.WriteLine(string.Join(" ",numbers).Reverse().ToArray());
        }
    }
}
