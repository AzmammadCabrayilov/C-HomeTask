using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Room1", 100, 3);
            Room room2 = new Room("Room2", 150, 5);
            Hotel h = new Hotel("Hilton");
            h.AddRooms(room1, room2);
            Console.WriteLine(h[0]);
            Console.WriteLine(h[1]);
        }
    }
}
