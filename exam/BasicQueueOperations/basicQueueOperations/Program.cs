using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nmbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < info[0]; i++)
            {
                queue.Enqueue(nmbers[i]);
            }
            for (int i = 0; i < info[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Contains(info[2]) ? "true" :$"{ queue.Min()}") ;
            }
        }
    }
}
