using System;
using System.Collections.Generic;

namespace _05recordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var name = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                name.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join("\n ", name));
        }
    }
}
