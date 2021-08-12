using System;

namespace _02asciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            int firstIndex = Math.Min(firstChar, secondChar);
            int secondIndex = Math.Max(firstChar, secondChar);
            int total = 0;
            foreach (var item in inputString)
            {

                if (item > firstIndex && item < secondIndex)
                {

                    total += item;

                }

            }
            Console.WriteLine(total);
        }
    }
}
