using System;

namespace CarManufacturer
{
   
    public class StartUp
    {
       public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "320";
            car.Year = 1999;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
