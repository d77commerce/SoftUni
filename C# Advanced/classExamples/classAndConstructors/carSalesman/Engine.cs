using System;
using System.Collections.Generic;
using System.Text;

namespace carSalesman
{
    public class Engine
    {
       
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public string Efficiency { get; set; } = "n/a";
        public string Displacemen { get; set; } = "n/a";
        public string Model { get; set; }
        public int Power { get; set; }
    }
}
