using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
   public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumation { get; set; }
        public void Drive (double dictanse)
        {
            var dictanPerFuel = dictanse * (FuelConsumation / 100);
            if (FuelQuantity - dictanPerFuel>=0)
            {
                FuelQuantity -= dictanPerFuel;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!&quot");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make} Model: { this.Model} Year: { this.Year} Fuel: { this.FuelQuantity:F2}";
        }
    }
}
