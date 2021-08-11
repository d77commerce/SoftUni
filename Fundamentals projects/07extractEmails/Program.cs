using System;
using System.Text.RegularExpressions;

namespace _07extractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            MatchCollection match = Regex.Matches(input, pattern);
            foreach (var item in match)
            {
                Console.WriteLine(item);
            }
        }
    }
}
