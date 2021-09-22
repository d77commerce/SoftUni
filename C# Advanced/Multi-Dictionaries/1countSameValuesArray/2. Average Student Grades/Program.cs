using System;
using System.Collections.Generic;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var studentsArray = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < num; i++)
            {
                string[] newStudent = Console.ReadLine().Split(' ');
                string student = newStudent[0];
                decimal grades = decimal.Parse(newStudent[1]);
                if (!studentsArray.ContainsKey(student))
                {
                    studentsArray[student] = new List<decimal>();
                }
                studentsArray[student].Add(grades);

            }
            foreach (var student in studentsArray)
            {
                Console.Write(student.Key + " -> ");
                decimal averDegre =0;
                foreach (var item in student.Value)
                {
                    Console.Write($"{item:f2} ");
                   
                    averDegre += item;
                } 
                Console.Write($"(avg: {averDegre/student.Value.Count:F2})");
                Console.WriteLine();
            }
        }
    }
}
