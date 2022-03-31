using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public abstract class Vehicle
    {
        private double _DriveTime;
        private double _DrivePath;

        public double DriveTime
        {
            get { return _DriveTime; }
            set
            {
                if (value > 0)
                {
                    _DriveTime = value;
                }
            }
        }

        public double DrivePath
        {
            get { return _DrivePath; }
            set
            {
                if (value > 0)
                {
                    _DrivePath = value;
                }
            }
        }

        public abstract double AverageSpeed();
        public abstract void Showinfo();
    }
}
