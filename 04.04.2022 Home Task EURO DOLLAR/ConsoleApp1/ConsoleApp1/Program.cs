using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(900);
            AZN azn = new AZN(1785);
            EUR euro = new EUR(742);

            AZN azn1 = usd;
            AZN azn2 = euro;

            USD usd1 = azn;
            USD usd2 = euro;

            EUR euro1 = azn;
            EUR euro2 = usd;
            Console.WriteLine(azn2.Amount);
        }
    }
}
