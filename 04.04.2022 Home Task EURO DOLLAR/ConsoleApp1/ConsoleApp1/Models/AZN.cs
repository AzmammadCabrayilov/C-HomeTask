using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class AZN
    {
        public double Amount { get; set; }
        public AZN(double amount)
        {
            Amount = amount;
        }

        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.69);
        }

        public static implicit operator AZN(EUR euro)
        {
            return new AZN(euro.Amount * 1.86);
        }
    }
}
