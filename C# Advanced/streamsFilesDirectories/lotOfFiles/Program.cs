using System;
using System.IO;

namespace lotOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                StreamWriter sw = new StreamWriter($"output{i}.txt");
                sw.WriteLine($"Hello No:{i}");
                sw.Close();
            }


        }
    }
}
