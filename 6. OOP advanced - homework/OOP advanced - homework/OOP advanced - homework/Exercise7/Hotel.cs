using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise7
{
    public static class Hotel
    {
        public static string Name { get; private set; } = "Pescarusul";
        public static int OccupiedRooms { get; set; } = 5;

        public static void RoomCheckout()
        {
            OccupiedRooms--;
        }

        public static void RoomCheckout(string goodbyeText)
        {
            Console.WriteLine($"{goodbyeText}! Check-out time: {DateTime.Now}.\nRooms occupied at the moment: {Hotel.OccupiedRooms}");
        }
    }
}
