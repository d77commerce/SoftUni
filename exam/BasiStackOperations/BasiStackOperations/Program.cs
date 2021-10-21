using System;
using System.Collections.Generic;
using System.Linq;

namespace BasiStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smalNum = int.MaxValue;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < info[0]; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = 0; i < info[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
                
            }
            else
            {
                Console.WriteLine(stack.Contains(info[2])? "true" :$" {stack.Min()}");
            }
           
        }
    }
}
