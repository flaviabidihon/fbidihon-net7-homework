using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise7
{
    public class RentedRoom : Room, IHotel, IRoom
    {
        private int _guestsNumber;
        public int GuestsNumber
        {
            get { return _guestsNumber; }
            set
            {
                if (value < 1 || value > 6)
                    throw new Exception("We can only accomodate a number of guests between 1 and 6.");
                _guestsNumber = value;
            }
        }

        public RentedRoom(int guestsNumber)
        {
            GuestsNumber = guestsNumber;
        }

        public override double GetRoomPrice()
        {
            if (GuestsNumber == 1)
                return 59.99;
            if (GuestsNumber == 2)
                return 89.99;
            if (GuestsNumber == 3)
                return 109.99;
            if (GuestsNumber > 3 && GuestsNumber < 7)
                return 159.99;
            else
                throw new Exception("Sorry, we cannot host you.");
        }

        public override void SpecialMessage()
        {
            if (GuestsNumber == 6)
                Console.WriteLine($"You have chosen the {Enum.GetName(typeof(RoomType), 4)}, which means you are rich. We will keep the change.");
            else
                Console.WriteLine("*rolls eyes watching the poor* Meh... Enjoy...");
        }

        public void GreetingGuest()
        {
            Console.WriteLine($"Welcome in Monaco! Hotel {Hotel.Name} is happy to host you!");
        }

        public bool CanRentPool()
        {
            if (GetRoomPrice() > 119.99)
                return true;
            return false;
        }

        public string ChangeTowels()
        {
            return "done";
        }

        public void RoomReady()
        {
            if (ChangeTowels() == "done")
                Console.WriteLine("The towels have been changed, so your room is prepared.");
        }
    }

    public enum RoomType
    {
        Single = 1,
        Double,
        Suite,
        Penthouse
    }
}


