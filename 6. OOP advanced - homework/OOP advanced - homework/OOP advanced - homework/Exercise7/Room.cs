using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise7
{
    public abstract class Room
    {
        public Room()
        {
            Hotel.OccupiedRooms++;
        }

        public abstract double GetRoomPrice();

        public virtual void SpecialMessage()
        {
            Console.WriteLine($"Enjoy!");
        }
    }
}
