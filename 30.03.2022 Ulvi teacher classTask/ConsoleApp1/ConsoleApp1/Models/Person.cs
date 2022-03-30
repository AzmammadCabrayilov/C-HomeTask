using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Person
    {
        private string _name;
        private string _surname;
        protected int _age;

        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }
        public string surname
        {
            get
            {
                return _surname;

            }
            set
            {
                _surname = value;

            }
        }
       
        public Person()
        {

        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this._age = age;
        }
    }
}
