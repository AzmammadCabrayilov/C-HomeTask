using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student : Person
    {
        private int _IQRank;
        private int _LanguageRank;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 6 && value < 20)
                {
                    _age = value;
                }
            }
        }
        public Student(string name,string surname, int age,int iqRank,int languageRank):base(name,surname,age)
        {
            IQRank = iqRank;
            LanguageRank = languageRank;
        }

        public int IQRank
        {
            get
            {
                return _IQRank;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _IQRank = value;
                }

            }
        }
        public int LanguageRank
        {
            get
            {
                return _LanguageRank;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _LanguageRank = value;
                }

            }
        }


        public void ExamResult()
        {
            double result = IQRank + LanguageRank;
            if (result < 120)
            {
                Console.WriteLine("Sinifde qaldi");
            }
            Console.WriteLine("tebrikler");
        }
    }
}
