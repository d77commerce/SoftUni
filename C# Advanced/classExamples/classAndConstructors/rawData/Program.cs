using System;
using System.Collections.Generic;
using System.Linq;

namespace rawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                List<Tire> newTyers = new List<Tire>();
                for (int j = 5;j <= 12; j += 2)
                {
                   Tire tier = new Tire(int.Parse(input[j+1]), double.Parse(input[j ]));
                    newTyers.Add(tier);
                }
                Engine engin = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(input[4], int.Parse(input[3]));
                Car newCar = new Car(input[0], engin, cargo, newTyers);
                cars.Add(newCar);
            }

            string action = Console.ReadLine();
            if (action=="fragile")
            {
                List<Car> fragileCar = cars.Where(x => x.Cargo.Type == "fragile" &&
                x.Tires.Any(y => y.Pressure < 1)).ToList();
                foreach (var item in fragileCar)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if(action== "flammable")
            {
                List<Car> flammable = cars.Where(x => x.Cargo.Type == "flammable" &&
                x.Engine.Power > 250).ToList();
                foreach (var item in flammable)
                {
                    Console.WriteLine( item.Model);
                }
             
            }
        }
    }
}
