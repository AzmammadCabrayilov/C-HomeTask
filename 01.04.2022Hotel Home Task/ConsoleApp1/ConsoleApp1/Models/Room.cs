using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Room
    {
        private static  int _ID;
        public int ID { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public string ShowInfo()
        {
            return $@"ID - {ID}
Name - {Name}
Price - {Price}
Room's person capacity - {PersonCapacity}
Can be Reserved - {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

        public Room(string name, double price, int personCapacity )
        {
            _ID++;
            ID = _ID;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
    }
}
