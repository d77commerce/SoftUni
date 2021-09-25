using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07party
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var taypeGuest = new Dictionary<string, Dictionary<string, HashSet<int>>>();
            taypeGuest.Add("vip", new Dictionary<string, HashSet<int>>());
            taypeGuest.Add("regular",new Dictionary<string, HashSet<int>>());
            while (command != "PARTY")
            {
                if (Regex.IsMatch(command, @"^[\d]*"))
                {
                    
                    taypeGuest["vip"].Add(command, new HashSet<int>(1));
                    
                }
                else
                {
                    taypeGuest["regular"].Add(command, new HashSet<int>(1));
                }

                command = Console.ReadLine();
            }
            while (command == "END")
            {

                Console.WriteLine(string.Join("\n",taypeGuest.Values));
            }
        }
    }
}
