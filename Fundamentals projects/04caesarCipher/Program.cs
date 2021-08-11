using System;
using System.Collections.Generic;
using System.Text;

namespace _04caesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
           
            for (int i = 0; i < sb.Length; i++)
            {
                int charInt = (int)sb[i]+3;
                char newChar = Convert.ToChar(charInt);

                sb[i] = newChar;
            }
            Console.WriteLine(sb);
        }
    }
}
