using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    static class Extention
    {
        public static int Power(this int firstNumber, int secondNumber)
        {
            return (int)Math.Pow(secondNumber, firstNumber);


        }
    }
}
