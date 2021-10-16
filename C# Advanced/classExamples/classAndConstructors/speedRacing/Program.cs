using System;
using System.Collections.Generic;
using System.Linq;

namespace speedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car car = new Car();
            int n = int.Parse(Console.ReadLine());
            List<Car> car = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                car[i].Model = input[0];
                car[i].FuelAmount = double.Parse(input[1]);
                car[i].FuelConsumptionPerKilometer = double.Parse(input[2]);
            }

            while (true)
            {
                string[] action = Console.ReadLine().Split(" ").ToArray();
                if (action[0] == "End")
                {
                    break;
                }
                car.First(x => x.Model == action[0]).Moving(double.Parse(action[1]));
            }
            foreach (var item in car)
            {
                Console.WriteLine($"{ item.Model} { item.FuelAmount:f2} { item.DistanceTravelled}");
            }
        }
    }
}
