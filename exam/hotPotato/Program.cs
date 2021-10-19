using System;
using System.Collections.Generic;

namespace hotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kid = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            while (kid.Count > 1)
            {
                for (int i = 1; i <n; i++)
                {
                    kid.Enqueue(kid.Dequeue());
                }
                Console.WriteLine($"Removed {kid.Dequeue()}");
            }
            Console.WriteLine($"Last is {kid.Peek()}"); 
        }
    }
}
