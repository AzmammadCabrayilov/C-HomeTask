using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
     class Car : Vehicle , IEngine  ,IWheel,ITransmission
    {
        private int _DoorCount;
        private int _WinCode;

        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int WhellTickness { get; set; }
        public int TransmissionKind { get; set; }
        public override double AverageSpeed()
        {
            throw new NotImplementedException();
        }

        public double LeftFuelAmount()
        {
            throw new NotImplementedException();
        }

        public override void Showinfo()
        {
            throw new NotImplementedException();
        }
    }
}
