using System;

namespace definingClassesExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] dateOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            DateTime date1 = new DateTime(int.Parse(dateOne[0]),
                int.Parse(dateOne[1].Trim('0')),
                int.Parse(dateOne[2].Trim('0')));
            string[] dateTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            DateTime date2 = new DateTime(int.Parse(dateTwo[0]), int.Parse(dateTwo[1].Trim('0')),
                int.Parse(dateTwo[2].Trim('0')));
            Console.WriteLine(DateModifier.GetData(date1, date2));
            
        }
    }
}
