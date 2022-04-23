using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_and_Room_Practise.Models
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms = new Room[0];
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public void MakeReservation(int ? roomId)
        {
            if (roomId == null)
            {
                Console.WriteLine("Otaq yoxdur!");
            }
            foreach (Room room in _rooms)
            {
                if (room.Id == roomId)
                {
                    if (room.IsAvailable == true)
                        room.IsAvailable = false;
                    else
                    {
                        Console.WriteLine("Otaq hal hazirda doludur");
                    }
                }
            }
        }
    }
}
