﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linqTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = list.OrderByDescending(x => x).
                Where(x => x % 2 == 0).
                Select(x => x * x);
            Console.WriteLine(string.Join(", ",newList));
        }
    }
}
