using System;
using System.Collections.Generic;
using System.Linq;

namespace _01validUserName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x)
                 .ToList();
            foreach (var item in input)
            {
                if (item.Length < 3 || item.Length > 15)
                {
                    continue;
                }
                bool valid = false;
                foreach (var courentChar in item)
                {
                    if (!(char.IsLetterOrDigit(courentChar) || courentChar == '-' || courentChar == '_'))
                    {

                        valid = false;
                        break;
                    }
                    valid = true;


                }
                if (valid == true)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
