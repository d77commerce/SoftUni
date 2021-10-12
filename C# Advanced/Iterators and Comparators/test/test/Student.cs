using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
   public class Student
    {
        public string Name { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
        public List<double> Grades { get; set; }
        public double PrintGrades()
        {
           
            return Grades.Sum()/Grades.Count;
        }
    }
}
