using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, long> func = Sum;

            Console.WriteLine(func(3,4));
            Console.WriteLine(func(4,4));
            Console.WriteLine(func(5,4));
            Console.WriteLine(func(6,4));
        }
        static long Multi(int a, int b)
        {
            return a * b;
        }
        static long Sum(int a, int b)
        {
            return a + b;
        }
    }
}
