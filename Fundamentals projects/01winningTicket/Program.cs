using System;
using System.Text.RegularExpressions;

namespace _01winningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in input)
            {
                string ticket = item.Trim();
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string lSide = ticket.Substring(0, 10);
                string rSide = ticket.Substring(10, 10);
                Match left = Regex.Match(lSide, @"([\$#\@\^])\1{5,9}");
                Match right = Regex.Match(rSide, @"([\$#\@\^])\1{5,9}");
                int result = Math.Min(left.Length, right.Length);
                if (result >= 6 && result <= 10)
                {
                    string index = right.Value.Substring(0, result);
                    if (left.Success == right.Success)
                    {
                        if (result == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {result}{index[0]} Jackpot!");
                            continue;
                        }
                        Console.WriteLine($"ticket \"{ticket}\" - {result}{index[0]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
