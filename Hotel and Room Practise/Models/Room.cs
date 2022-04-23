using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_and_Room_Practise.Models
{
    public class Room
    {
        public int Id { get; }
        private static int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room()
        {
            _id++;
            Id = _id;
        }
        public Room(string name,double price,int personCapacity):this()
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Id <==> {Id } Name <==> {Name} Person Capacity <==> {PersonCapacity} Price <==> {Price} Is Available <==> {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
