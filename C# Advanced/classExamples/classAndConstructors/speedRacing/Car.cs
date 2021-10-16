using System;
using System.Collections.Generic;
using System.Text;

namespace speedRacing
{
    //    
    //double 
    //double 
    //double 
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
           
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double DistanceTravelled { get; set; } = 0;
        public void Moving(double distance)
        {


            if ( FuelAmount>=distance*FuelConsumptionPerKilometer)
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                DistanceTravelled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }

}

