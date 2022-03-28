using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Singer
    {
        private string _Name;
        private string _SurName;
        public int _Age;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {

                    _Name = value;
                }
            }
        }

        public string SurName
        {
            get
            {
                return _SurName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {
                    _SurName = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value > 0 && value <= 170)
                {
                    _Age = value;
                }
            }
        }

        public Singer(string name,string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
    }
}