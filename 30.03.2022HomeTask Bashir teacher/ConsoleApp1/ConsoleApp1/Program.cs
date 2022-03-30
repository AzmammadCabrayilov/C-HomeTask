using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int includedNumber = 1;
            while (includedNumber > 0 && includedNumber <= 2)
            {
                includedNumber = Convert.ToInt32(Console.ReadLine());
                switch (includedNumber)
                {
                    case 1:
                        Square square = new Square(21);
                        square.CalcArea();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the square width");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the square heigth");
                        double heigth = Convert.ToDouble(Console.ReadLine());
                        Rectangular rtgn = new Rectangular(width, heigth);
                        rtgn.CalcArea();
                        break;
                    default :
                        Console.WriteLine("Quit Program");
                        break;
                }
            }
        }
    }
}
