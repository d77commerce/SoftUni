using System;
using System.Collections.Generic;

namespace _03productShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopArray = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");
                if (input[0] == "Revision")
                {
                    break;
                }
                var shop = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);
                if (!shopArray.ContainsKey(shop))
                {
                    shopArray[shop] = new Dictionary<string, double>();
                }
                shopArray[shop].Add(product, price);
            }
            foreach (var shop in shopArray)
            {
                Console.WriteLine(shop.Key+"->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }           
        }
    }
}
