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
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                Car newCar = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                car.Add(newCar);
            }

            while (true)
            {
                string[] action = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (action[0] == "End")
                {
                    break;
                }
                car.First(x => x.Model == action[1]).Moving(double.Parse(action[2]));
            }
            foreach (var item in car)
            {
                Console.WriteLine($"{ item.Model} { item.FuelAmount:f2} { item.DistanceTravelled}");
            }
        }
    }
}
