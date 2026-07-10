using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    internal class Room
    {
        public string roomNumber { get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        public double pricePerNight { get; set; }
        public bool occupied { get; set; }
        public string guestName { get; set; }

        public Room(string roomNumber, string type, int capacity, double pricePerNight, bool occupied, string guestName)
        {
            this.roomNumber = roomNumber;
            this.type = type;
            this.capacity = capacity;
            this.pricePerNight = pricePerNight;
            this.occupied = occupied;
            this.guestName = guestName;
        }

        public string ToFileRow()
        {
            
            return $"{roomNumber};{type};{capacity};{pricePerNight};{occupied};{guestName}";
        }

        public void PrintRoomInfo()
        {
            if (occupied == true)
            {
                Console.WriteLine("Стая: " + roomNumber + " | Тип: " + type + " | Капацитет: " + capacity + " души | Цена: " + pricePerNight + " евро | Статус: Заета от " + guestName);
            }
            else
            {
                Console.WriteLine("Стая: " + roomNumber + " | Тип: " + type + " | Капацитет: " + capacity + " души | Цена: " + pricePerNight + " евро | Status: Свободна");
            }
        }
    }
}
