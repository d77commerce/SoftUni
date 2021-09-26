using System;
using System.IO;

namespace fileStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fileReader = new FileStream("oneInput.txt", FileMode.OpenOrCreate);
            byte[] bufer = new byte[100];
            fileReader.Read(bufer);
            Console.WriteLine(string.Join(" ",bufer));
        }
    }
}
