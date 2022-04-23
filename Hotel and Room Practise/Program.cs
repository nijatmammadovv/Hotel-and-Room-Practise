using Hotel_and_Room_Practise.Models;
using System;

namespace Hotel_and_Room_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("Nomre1", 255, 2);
            Room room1 = new Room("Nomre2", 150, 1);
            Console.WriteLine("================================");
            Hotel hotel = new Hotel("Hilton Baku");
            hotel.AddRoom(room);
            hotel.AddRoom(room1);
            Console.WriteLine("================================");
            foreach (var item in hotel._rooms)
            {
                Console.WriteLine(item.ToString());
            }
            hotel.MakeReservation(2);

            foreach (var item in hotel._rooms)
            {
                Console.WriteLine(item.ToString());
            }
            hotel.MakeReservation(2);
        }
    }
}
