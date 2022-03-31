using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    static class Calculator
    {
        public static int Sum(int first,int second)
        {
            return first + second;
        }

        public static int Subtract(int first,int second)
        {
            return first - second;

        }

        public static int Multiply(int first, int second)
        {
            return first * second;

        }

        public static int Divide(int first, int second)
        {
            return first / second;

        }
    }
}
