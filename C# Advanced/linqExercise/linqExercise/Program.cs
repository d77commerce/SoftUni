using System;
using System.Linq;

namespace linqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInt = Console.ReadLine().
                Split(", ").
                 Select(int.Parse).
                 Where(x => x % 2 == 0).
                 OrderBy(x => x);
            Console.WriteLine(string.Join(", ",listInt));
        }
    }
}
