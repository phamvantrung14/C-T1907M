using System;
using System.Collections.Generic;

namespace Hotel
{
    public class Book
    {
        
        public int CheckIn { get; set; }
        public int CheckOut { get; set; }
        public string CMTND { get; set; }
        public string HotelNo { get; set; }
        public string RoomNo { get; set; }

        public Book()
        {
        }

        public void Input(List<Cutomer> cutomerList, List<Hotel> hotelList)
        {
            Console.WriteLine("Nhap CMTND khach hang: ");
            CMTND = Console.ReadLine();
            bool isFind = false;
            //kiem tra thong tin khach hang
            for (int i = 0; i < cutomerList.Count; i++)
            {
                if (cutomerList[i].CMTND.Equals(CMTND))
                {
                    isFind = true;
                    break;
                }
            }
            //them moi thong tin khach hang
            if (!isFind)
            {
                Console.WriteLine("khach hang chua ton tai, se duoc nhap moi");
                Cutomer cutomer = new Cutomer();
                cutomer.CMTND = CMTND;
                cutomer.InputWithoutCMTND();
                cutomerList.Add(cutomer);
            }
            
            //nhap ma khach san.
            DisplayHotelMenu(hotelList);
            Hotel hotel = null;
            while (true)
            {
                HotelNo = Console.ReadLine();
                isFind = false;
                for (int i = 0; i < hotelList.Count; i++)
                {
                    if (hotelList[i].No.Equals(HotelNo))
                    {
                        isFind = true;
                        hotel = hotelList[i];
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }else {
                    Console.WriteLine("Nhap lai ma khach san: ");
                }
                
            }
            //nhap ma phong
            DisplayRoomMenu(hotel);
            RoomNo = Console.ReadLine();
            isFind = false;
            while (true)
            {
                RoomNo = Console.ReadLine();
                for (int i = 0; i < hotel.roomList.Count; i++)
                {
                    if (hotel.roomList[i].No.Equals(RoomNo))
                    {
                        isFind = true;
                       
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma phong : ");
                }
            }
            //nhap thong tin ngay book va ngay tra
            Console.WriteLine("Nhap ngay dat phong: ");
            CheckIn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay tr phong: ");
            CheckOut = Int32.Parse(Console.ReadLine());
            //ends
        }

        public void DisplayHotelMenu( List<Hotel> hotelList)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}",i+1,hotelList[i].Name,hotelList[i].No);
            }
            Console.WriteLine("Nhap ma khach san can chon");
        }

        public void DisplayRoomMenu(Hotel hotel)
        {
            for (int i = 0; i < hotel.roomList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}",i+1,hotel.roomList[i].Name,hotel.roomList[i].No);
            }
            Console.WriteLine("Nhap ma phong");
        }
    }
}