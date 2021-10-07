using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Make = "BMW";
            car.Model = "320";
            car.Year = 1999;
            car.FuelQuantity = 150;
            car.FuelConsumation = 15;
            car.Drive(199);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
