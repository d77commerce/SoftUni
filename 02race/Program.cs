using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            string inPut = Console.ReadLine();
            Dictionary<string, int> playerResult = new Dictionary<string, int>();
            foreach (var neme in names)
            {
                playerResult.Add(neme, 0);
            }
            while (inPut!= "end of race")
            {
                string playerFromInput = string.Empty;
                MatchCollection inPlayer =  Regex.Matches(inPut, @"[A-Za-z]");
                foreach (Match item in inPlayer)
                {
                    playerFromInput += item.Value;
                  //  Console.WriteLine(playerFromInput);
                }
                int kmInput = 0;
                MatchCollection km = Regex.Matches(inPut, @"[0-9]");
                foreach (Match digit in km)
                {
                    kmInput += int.Parse(digit.Value);
                  //  Console.WriteLine(kmInput);
                }
                if (playerResult.ContainsKey(playerFromInput))
                {
                    playerResult[playerFromInput] += kmInput;
                }
                else
                {
                    inPut = Console.ReadLine();
                    continue;
                }
               

                inPut = Console.ReadLine();
            }
            int counter = 1;
            foreach (var item in playerResult.OrderByDescending(x => x.Value))
            {
                if (counter==1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if(counter==2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                counter++;
            }
        }
    }
}
