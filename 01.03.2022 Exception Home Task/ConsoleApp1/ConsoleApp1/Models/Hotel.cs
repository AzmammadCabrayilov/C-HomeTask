using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Hotel
    {
        private string _Name;
        private Room[] Rooms = new Room[10];

        public string Name { get; set; }
        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);

        }
    }
}
