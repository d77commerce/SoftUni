using System;
using System.Collections.Generic;
using System.Linq;

namespace printEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inpit = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(inpit);
            
            int count = queue.Count();
            for (int j = 0; j < count; j++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    queue.Enqueue(queue.Dequeue());
                    continue;
                }
                queue.Dequeue();

            }
            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
