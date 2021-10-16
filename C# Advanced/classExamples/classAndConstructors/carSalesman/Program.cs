using System;
using System.Collections.Generic;
using System.Linq;

namespace carSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            int engineN = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineN; i++)
            {
                string[] engineIput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(engineIput[0], int.Parse(engineIput[1]));
                if (engineIput.Length > 2)
                {
                    if (char.IsDigit(engineIput[2][0]))
                    {
 engine.Displacemen = engineIput[2];
                    }
                    else
                    {
                        engine.Efficiency = engineIput[2];
                    }
                   
                }
                if (engineIput.Length > 3)
                {
                    engine.Efficiency = engineIput[3];
                }
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInput[0], engines.FirstOrDefault(x => x.Model == carInput[1]));
                if (carInput.Length > 2)
                {
                    if (char.IsDigit(carInput[2][0]))
                    {
                        car.Weight = carInput[2];
                    }
                    else
                    {
                        car.Color = carInput[2];
                    }
                }
                if (carInput.Length > 3)
                {
                    car.Color = carInput[3];
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"     Power: {car.Engine.Power}");
                Console.WriteLine($"     Displacement: {car.Engine.Displacemen}");
                Console.WriteLine($"     Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
