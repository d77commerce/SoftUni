using System;
using System.Linq;

namespace countAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(MyParce);
            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }

        static int MyParce(string intToString)
        {
            int num = 0;
            foreach (var digitChar in intToString)
            {
                num *= 10;
                num += (digitChar - '0');
            }
            return num;
        }
    }
}
