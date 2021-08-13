using System;
using System.Collections.Generic;
using System.Linq;

namespace _07studentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            decimal grade = 0;
            var result = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                grade = decimal.Parse(Console.ReadLine());
                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<decimal>());
                }
                result[name].Add(grade);
            }
            foreach (var student in result.OrderByDescending(x => x.Value.Average())) 
            {
                decimal totalDegre = 0;
                foreach (var degre in student.Value)
                {
                    totalDegre += degre;
                }
                totalDegre = totalDegre / student.Value.Count;
                if (totalDegre >= (decimal)4.5)
                {

                    Console.WriteLine($"{student.Key} -> {totalDegre:F2}");
                }

            }
        }
    }
}
