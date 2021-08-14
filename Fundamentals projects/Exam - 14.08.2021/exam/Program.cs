using System;
using System.Text.RegularExpressions;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patName = @"\|([A-Z]{2,})\|";
            string pat = @"\|([A-Z]{2,})\|\:#([A-z]{1,} [A-z]{1,})#";
            string patTitle = @"\|\:#([A-z]{1,} [A-z]{1,})#";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pat);
                MatchCollection matches = regex.Matches(input);
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine($"Access denied!");
                }
                foreach (Match item in matches)
                {
                    Console.WriteLine($"{item.Groups[1]}, The {item.Groups[2]}");
                    Console.WriteLine($">> Strength: {item.Groups[1].Length}");
                    Console.WriteLine($">> Armor: {item.Groups[2].Length}");
                }

            }
        }
    }
}
