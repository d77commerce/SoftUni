using System;
using System.Collections.Generic;
using System.Linq;

namespace _002.censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string replayWord = new string('*', word.Length);
            string sentence = Console.ReadLine()
                .Replace(word, replayWord);

            Console.WriteLine(sentence);
        }
    }
}
