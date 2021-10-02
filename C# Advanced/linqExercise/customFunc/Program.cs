using System;
using System.Linq;

namespace customFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();
            Func<int[], int> getSmallNum = numers =>
            {
                int minValue = int.MaxValue;
                foreach (var item in numers)
                {
                    if (minValue > item)
                    {
                       minValue= item;
                    }
                }
                return minValue;
            };
            Console.WriteLine(getSmallNum(input));
        }
    }
}
