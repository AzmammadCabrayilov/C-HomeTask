using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static object Empl { get; private set; }

        static void Main(string[] args)
        {
            double salary = Convert.ToDouble(Console.ReadLine());
            int hour = Convert.ToInt32(Console.ReadLine());
            Employee emp1 = new Employee(salary, hour);
            Console.WriteLine(emp1.CalculateSalary());
        }
    }
}
