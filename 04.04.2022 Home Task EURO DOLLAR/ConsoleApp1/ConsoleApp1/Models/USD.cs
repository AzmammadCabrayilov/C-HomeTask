using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class USD
    {
        public double Amount { get; set; }
        public USD(double amount)
        {
            Amount = amount;
        }

        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount * 0.58);
        }

        public static implicit operator USD(EUR euro)
        {
            return new USD(euro.Amount * 1.09);
        }
    }
}
