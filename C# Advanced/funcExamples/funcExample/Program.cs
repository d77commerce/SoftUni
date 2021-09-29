using System;

namespace funcExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, long> func = Sum;
            PrintResult(2, 3, func);
        }
        static long Multiply(int a, int b)
        {
            return a * b;
        }
        static long Sum(int a, int b)
        {
            return a + b;
        }
        static void PrintResult(int a, int b, Func<int, int, long> func)
        {
            for (int i = 1; i < 5; i++)
            {
                var result = func(a + i, b + i);
                Console.WriteLine(new string('=', 50));
                Console.WriteLine($" Result: {result}");
                Console.WriteLine(new string('=', 50));
            }

        }
    }
}
