using System;
using System.Collections.Generic;
using System.Text;

namespace definingClassesExercise
{
    class DateModifier
    {
        public static double GetData(DateTime dateTime1, DateTime dateTime2)
        {
            double result = Math.Abs((dateTime1 - dateTime2).TotalDays);
            return result;
        }
    }
}
