using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06parkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var carpark = new HashSet<string>();
            while (input != "END")
            {
                var command = Regex.Split(input, ", ");
                if (command[0] == "IN")
                {
                    carpark.Add(command[1]);
                }
                else
                {
                    carpark.Remove(command[1]);
                }
                input = Console.ReadLine();
            }
            if (carpark.Count < 1)
            {
                Console.WriteLine("Parking Lot is Empty");

            }
            else
            {
Console.WriteLine(string.Join("\n",carpark));
            }
            
        }
    }
}
