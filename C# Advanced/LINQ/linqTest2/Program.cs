using System;
using System.Collections.Generic;
using System.Linq;

namespace linqTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = list.Where(evenNum);
            Console.WriteLine(string.Join(", ",newList));
        }
        static bool evenNum(int a) => a % 2 == 0;
    }
}
