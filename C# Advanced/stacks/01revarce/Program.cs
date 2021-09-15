using System;
using System.Collections.Generic;

namespace _01revarce
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string inPut = Console.ReadLine();
            foreach (var ch in inPut)
            {
                stack.Push(ch);
            }
            while (stack.Count>0)
            {

                Console.Write(stack.Pop());
            }

        }
    }
}
