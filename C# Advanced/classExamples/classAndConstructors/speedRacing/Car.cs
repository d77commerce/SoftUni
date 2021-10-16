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
       
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double DistanceTravelled { get; set; } = 0;
        public void Moving(double distance)
        {


            if (distance * FuelConsumptionPerKilometer >= FuelAmount)
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

