using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Rectangular:Figure
    {
        private double _width;
        private double _heigth;

        public double width
        {
            get { return _width; }
            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
            }
        }
        public double heigth
        {
            get { return _heigth; }
            set
            {
                if (value >= 0)
                {
                    _heigth = value;
                }
            }
        }

        public Rectangular(double width,double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public override void CalcArea()
        {
            Console.WriteLine("CalcArea Restangularda ise dushdu");
        }
    }
}
