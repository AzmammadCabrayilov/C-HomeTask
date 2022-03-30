using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Employee:Person
    {
        private double _salaryPerHour;
        private int _workingHour;
        private double salary;
        private int hour;

        public double SalaryPerHour
        {
            get
            {
                return _salaryPerHour;
            }
            set
            {
                _salaryPerHour = value;

            }
        }
        public int workingHour
        {
            get
            {
                return _workingHour;
            }
            set
            {
                _workingHour = value;

            }
        }

        public Employee(string name, string surname, int age,  int salaryHour,int workingHour) : base(name, surname, age)
        {
            SalaryPerHour = salaryHour;
            this.workingHour = workingHour;
        }

        public Employee(double salary, int hour)
        {
            this.salary = salary;
            this.hour = hour;
        }

        public double CalculateSalary()
        {
            double result = workingHour * SalaryPerHour;
            if (result > 250)
            {
                return result;
            }
            return 0;
        }
    }
}
