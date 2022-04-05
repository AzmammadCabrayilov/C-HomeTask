using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class EUR
    {
        public double Amount { get; set; }
        public EUR(double amount)
        {
            Amount = amount;
        }

        public static implicit operator EUR(AZN azn)
        {
            return new EUR(azn.Amount * 0.53);
        }

        public static implicit operator EUR(USD usd)
        {
            return new EUR(usd.Amount * 0.91);
        }
    }
}
