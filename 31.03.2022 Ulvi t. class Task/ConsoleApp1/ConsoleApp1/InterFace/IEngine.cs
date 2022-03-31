using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    interface  IEngine
    {
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public abstract double LeftFuelAmount();
      
    }
}
