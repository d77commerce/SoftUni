﻿using System;

namespace genericBoxString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Box<int> input = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(input.ToString());
            }
        }
    }
}
