using System;

namespace _03emailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('@');
            string left = input[0];
            string right = input[1];
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < left.Length; i++)
            {
                leftSum += left[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                rightSum += right[i];
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Call her!");
            }
            else
            {
                Console.WriteLine($"She is not the one.");
            }
        }
    }
}
