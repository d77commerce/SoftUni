using System;

namespace linqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Multiply(2, 3);
            Console.WriteLine($"result {result}");
            Func<int, int, long> func = Multiply;
            Console.WriteLine($"func1 - {func(2, 3)}");
            Func<int, int, long> func2 = Sum;
            Console.WriteLine($"func2 - {func2(2, 3)}");
            Func<string> func3 = Greating;
            
            Console.WriteLine(func3());

        }
        static long Multiply(int a, int b)
        {
            return a * b;
        }
        static long Sum(int a, int b)
        {
            return a + b;
        }
        static string Greating()
        {
            return "Hallo";
        }

    }
}
