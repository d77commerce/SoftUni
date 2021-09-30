using System;
using System.Linq;

namespace vat
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x * 1.2);
            foreach (var numVat in numbers)
            {
                Console.WriteLine($"{numVat:f2}");
            }
        }
    }
}
