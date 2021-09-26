using System;
using System.IO;

namespace filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[] { 64, 83, 111, 102, 116, 33 };
            using FileStream fileStream = new FileStream("testOut.txt", FileMode.OpenOrCreate);
            fileStream.Write(data);
        }
    }
}
