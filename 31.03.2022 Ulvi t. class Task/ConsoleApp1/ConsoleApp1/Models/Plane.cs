using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Plane:Vehicle,IEngine,ITransmission
    {
        private double _WingLength;

        public int HorsePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TankSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TransmissionKind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
