using System;
using System.Collections.Generic;

namespace Hotel
{
    public class Hotel
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Room> roomList = new List<Room>();

        public Hotel()
        {
        }

        public void Input()
        {
            Console.WriteLine("Nhap ma khach san: ");
            No = Console.ReadLine();
            Console.WriteLine("Nhap ten khach san: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap Dia chi: ");
            Address = Console.ReadLine();
            Console.WriteLine("Nhap loai phong: ");
            Type = Console.ReadLine();
            
            Console.WriteLine("Nhap so phong can them: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Room room =new Room();
                room.Input();
                roomList.Add(room);
            }
            
        }

        public void Display()
        {
            Console.WriteLine("Hotel (Ten khach san: {0}, Dia chi: {1}, Loai phong: {2}, Ma khach san: {3}",
                Name,Address,Type,No);
            for (int i = 0; i < roomList.Count; i++)
            {
                roomList[i].display();
            }
        }
        
        public void DisplayBase()
        {
            Console.WriteLine("Hotel (Ten khach san: {0}, Dia chi: {1}, Loai phong: {2}, Ma khach san: {3}",
                Name,Address,Type,No);
           
        }
    }
}