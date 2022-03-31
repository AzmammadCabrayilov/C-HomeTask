using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Bicycle:Vehicle,IWheel
    {
        private string _PedalKind;
        private double _WheelThickness;

        public string PedalKind { get; set; }
        public double WheelThickness { get; set; }
        public int WhellTickness { get; set; }

        public override double AverageSpeed()
        {
            throw new NotImplementedException();
        }

        public override void Showinfo()
        {
            throw new NotImplementedException();
        }
    }
}
