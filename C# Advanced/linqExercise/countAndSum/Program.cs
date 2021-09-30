using System;
using System.Linq;

namespace countAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse);
            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}
