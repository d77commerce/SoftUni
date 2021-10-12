using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "dfhsfgh";
            student.Grades = new List<double>();
            student.Grades.Add(5.5);
            student.Grades.Add(6.6);
            Console.WriteLine(student.PrintGrades());

        }
    }
}
