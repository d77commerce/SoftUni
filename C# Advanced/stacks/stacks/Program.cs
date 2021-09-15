using System;
using System.Collections.Generic;

namespace stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);
            stack.Push(100);
            int element = stack.Pop();
            Console.WriteLine(element);
            Console.WriteLine(stack.Pop());
            stack.Push(24);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
        }
    }
}
