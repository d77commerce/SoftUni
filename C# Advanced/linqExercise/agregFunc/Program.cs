using System;
using System.Linq;

namespace agregFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(input.Sum());
            Console.WriteLine(input.Average());
            Console.WriteLine(input.Count());
        }
    }
}
