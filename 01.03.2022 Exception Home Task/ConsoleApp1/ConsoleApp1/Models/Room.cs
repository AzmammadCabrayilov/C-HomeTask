using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Room
    {
        private static int _ID;
        private string _Name;
        private double _Price;
        private int _PersonCapacity;
        public bool IsAvailable { get; set; } = true;

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }

        public int ChangeIDCount()
        {
            ID++;
            return ID;
        }

        public Room(int id, string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            ID = ChangeIDCount();
        }

        public string ShowInfo()
        {
            return $@"Name - {Name} Price - {Price} Our room's person capacity - {PersonCapacity} Room is reserved? - {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
