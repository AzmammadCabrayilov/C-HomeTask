using ConsoleApp1.Utilies.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Hotel
    {

        private Room[] rooms;
        public string Name { get; set; }

        public Room this[int index]
        {
            get
            {
                if (rooms.Length > index && index > 0)
                {
                    return rooms[index];
                }
                throw new Exception("Bele index yoxdur");
            }
            set
            {
                if (rooms.Length > index && index > 0)
                {
                    rooms[index] = value;
                    return;
                }
                throw new Exception("Bele index yoxdur");
            }

        }
        public Hotel(string Name)
        {
            this.Name = Name;
        }


        public void AddRooms(params Room[] arr)
        {
            int tempLength = rooms.Length;
            Array.Resize(ref rooms, rooms.Length + arr.Length);
            int roomI = 0;
            for (int i = tempLength; i < rooms.Length; i++)
            {
                rooms[i] = arr[roomI];
                roomI++;
            }
        }

        public void Reserve(int? number)
        {
            if (!(number is null))
            {
                if ((rooms[(int)number - 1] is null))
                {
                    if (rooms[(int)number - 1].IsAvailable)
                    {
                        rooms[(int)number - 1].IsAvailable = false;
                    }
                    else { throw new NotAvailableException("Otaq doludu"); }
                }
                else
                {
                    throw new NotFoundException("Otaq doludu");
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public override string ToString()
        {
            string result = Name + ":\n";
            foreach (var item in rooms)
            {
                result += item.ToString();
                result += "\n";
            }
            return result;
        }

    }
}
