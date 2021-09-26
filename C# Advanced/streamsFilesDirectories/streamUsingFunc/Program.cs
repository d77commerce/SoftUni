using System;
using System.IO;

namespace streamUsingFunc
{
    class Program
    {
        static void Main(string[] args)
            
        {
            using StreamReader sr = new StreamReader("countries.txt");
          using  StreamWriter sw = new StreamWriter("oddCountries.txt");
            var rowNum = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                sw.WriteLine(line);
                rowNum++;
            }
        }
    }
}
