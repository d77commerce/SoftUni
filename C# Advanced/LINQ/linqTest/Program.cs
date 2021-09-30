using System;
using System.Collections.Generic;
using System.Linq;

namespace linqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = listOfInt.Where(evenNum);
            Console.WriteLine(string.Join(" ", newList));
        }
        static bool evenNum (int f)
        {
            return f % 2 == 0;
        }

    }
}
