using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
        public Book(string title,int year)
        {
            year = Year;
            title = Title;
        }
    }
}
