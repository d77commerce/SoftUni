using System;
using System.Collections.Generic;
using System.Linq;

namespace _1countSameValuesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var countFunction = new Dictionary<double, int>();
            foreach (var i in input)
     
            {
                if (!countFunction.ContainsKey(i))
                {
                    countFunction[i] = 0;
                }
                countFunction[i] ++;
            }
            foreach (var item in countFunction)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
