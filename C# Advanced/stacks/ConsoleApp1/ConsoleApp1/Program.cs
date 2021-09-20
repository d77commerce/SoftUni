<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (var item in num)
            {
                stack.Push(int.Parse(item));
            }
            while (true)
            {
                string inPut = Console.ReadLine();
                string[] inputToArray = inPut.Split(' ');
                string comand = inputToArray[0].ToLower();
                if (comand == "add")
                {
                    stack.Push(int.Parse(inputToArray[1]));
                    stack.Push(int.Parse(inputToArray[2]));
                }
                else if (comand == "remove")
                {
                    int numToRemove = int.Parse(inputToArray[1]);
                    if (numToRemove <= stack.Count)
                    {
                        for (int i = 0; i < numToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (comand == "end")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            int total = 0;
            for (int i = 0; i <= stack.Count + 1; i++)
            {
                int sum = stack.Pop();
                total += sum;
            }
            Console.WriteLine($"Sum: {total}");

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (var item in num)
            {
                stack.Push(int.Parse(item));
            }
            while (true)
            {
                string inPut = Console.ReadLine();
                string[] inputToArray = inPut.Split(' ');
                string comand = inputToArray[0].ToLower();
                if (comand == "add")
                {
                    stack.Push(int.Parse(inputToArray[1]));
                    stack.Push(int.Parse(inputToArray[2]));
                }
                else if (comand == "remove")
                {
                    int numToRemove = int.Parse(inputToArray[1]);
                    if (numToRemove <= stack.Count)
                    {
                        for (int i = 0; i < numToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (comand == "end")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            int total = 0;
            for (int i = 0; i <= stack.Count + 1; i++)
            {
                int sum = stack.Pop();
                total += sum;
            }
            Console.WriteLine($"Sum: {total}");

        }
    }
}
>>>>>>> 632dd80a3184c34b04d16b52ae9b47109d977aa7
