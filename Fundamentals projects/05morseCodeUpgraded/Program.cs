using System;

namespace _05morseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string wordOutpt = string.Empty;
            int wordInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int one = 0;
                int zero = 0;
                string courantWord = input[i];
                int extraPoint = 0;
                foreach (var item in courantWord)
                {
                    if (item == '1')
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }
                    if (item ==item.)
                    {
                        extraPoint++;
                    }
                }
                wordInt = (zero * 3) + (one * 5) + extraPoint;
                Console.Write((char)wordInt);
                //Console.WriteLine(wordInt);
                wordInt = 0;
            }

        }
    }
}
