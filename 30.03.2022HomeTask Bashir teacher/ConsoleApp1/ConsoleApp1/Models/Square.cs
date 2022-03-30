using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Square:Figure
    {
        private int _side;

        public int side
        {
            get { return _side; }
            set
            {
                if (value >= 0)
                {
                    _side = value;
                }
            }
        }
        public  Square(int Side)
        {
            side = Side;
        }

   
        public override void CalcArea()
        {
            Console.WriteLine("CalcArea Squarede ise Dushdu");
        }
    }
}
