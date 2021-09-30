using System;
using System.Linq;

namespace countUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().
                Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> wordFunc = word => char.IsUpper(word[0]);
            var upWords = input.Where(wordFunc);
            foreach (var word in upWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
