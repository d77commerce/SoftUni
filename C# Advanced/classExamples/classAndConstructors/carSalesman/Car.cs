﻿using System;
using System.Collections.Generic;
using System.Text;

namespace carSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; } = "n/a";
        public string Color { get; set; } = "n/a";
    }
}
