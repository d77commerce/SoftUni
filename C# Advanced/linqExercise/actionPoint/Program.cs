using System;
using System.Linq;

namespace actionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ");
          
                Action<string> print = name => Console.WriteLine(name);
            foreach (var item in input)
            {
                print(item);
            }

        }
    }
}
