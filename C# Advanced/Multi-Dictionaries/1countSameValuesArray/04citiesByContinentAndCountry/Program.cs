using System;
using System.Collections.Generic;

namespace _04citiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continentDict = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string sity = input[2];
                if (!continentDict.ContainsKey(continent))
                {
                    continentDict[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentDict[continent].ContainsKey(country))
                {
                    continentDict[continent].Add(country, new List<string>());
                }
                continentDict[continent][country].Add(sity);
            }
            foreach (var continent in continentDict)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var city in continentDict[continent.Key])
                {
                    Console.Write($"  {city.Key} -> ");
                    Console.Write(string.Join(", ", city.Value));
                    Console.WriteLine();
                }

            }
        }
    }
}
