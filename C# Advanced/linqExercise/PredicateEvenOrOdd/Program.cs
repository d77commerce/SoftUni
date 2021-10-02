using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intInput = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            Predicate<int>resultEven = x => x % 2 == 0;
            Predicate<int>resultOdd = x => x % 2 != 0;
            string action = Console.ReadLine();
            var input = new List<int>();
            for (int i = intInput[0]; i <= intInput[1]; i++)
            {
                input.Add(i);
            }
            if (action=="even")
            {
                foreach (var num in input)
                {
                    if (resultEven(num))
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            else if(action=="odd")
            {
                foreach (var num in input)
                {
                    if (resultOdd(num))
                    {
                        Console.WriteLine(num);
                    }
                }
            }
           
                    
            
        }
    }
}
