using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cutomer> cutomerList = new List<Cutomer>();
            List<Hotel> hotelList = new List<Hotel>();
            List<Book> bookList = new List<Book>();
            int choose;
            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Input(hotelList);
                        break;
                    case 2:
                        Display(hotelList);
                        break;
                    case 3:
                        InputBook(bookList,cutomerList,hotelList);
                        break;
                    case 4:
                        SearchAvailableBook( bookList, hotelList);
                        break;
                    case 5:
                        Statistic(bookList, hotelList);
                        break;
                    case 6:
                        Search(bookList, hotelList);
                        break;
                    case 7:
                        Console.WriteLine("Exit Program.");
                        break;
                    default:
                        Console.WriteLine("Input Failed");
                        break;
                }
            } while (choose!=7);
        }

        static void Search(List<Book> bookList, List<Hotel> hotelList)
        {
            Console.WriteLine("Nhap CMTND can tim kiem : ");
            string cmtnd = Console.ReadLine();
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Equals(cmtnd))
                {
                    Hotel hotel = GetHotelByNo(hotelList, bookList[i].HotelNo);
                    if (hotel!=null)
                    {
                        hotel.DisplayBase();
                    }
                }
            }
        }

        static Hotel GetHotelByNo(List<Hotel> hotelList, string hotelNo)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                if (hotelList[i].No.Equals(hotelNo))
                {
                    return hotelList[i];
                }
            }
            return null;
        }
        
        //thong ke doanh thu
        static void Statistic(List<Book> bookList,List<Hotel> hotelList)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                int total = Calculate(bookList, hotelList[i]);
                Console.WriteLine("{0}. {1} - Doanh thu : {2}",i+1,hotelList[i].Name,total);
            }
        }
        static int Calculate(List<Book> bookList, Hotel hotel)
        {
            int total = 0;
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].HotelNo.Equals(hotel.No))
                {

                    int price = GetMoney(hotel.roomList, bookList[i].RoomNo);
                    total += price * (bookList[i].CheckOut - bookList[i].CheckIn);
                }
            }

            return total;
        }

        static int GetMoney(List<Room> roomList, string rooNo)
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].No.Equals(rooNo))
                {
                    return roomList[i].Price;
                }
            }

            return 0;
        }
        static void SearchAvailableBook(List<Book> bookList, List<Hotel> hotelList)
        {
            int checkIn;
            int checkOut;
            Console.WriteLine("Nhap ngay dat phong : ");
            checkIn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay tra phong : ");
            checkOut = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < hotelList.Count; i++)
            {
                hotelList[i].DisplayBase();
                Console.WriteLine("---- Danh sach phong trong ----");
                List<Room> rooms = hotelList[i].roomList;
                for (int j = 0; j < rooms.Count; j++)
                {
                    if (CheckAvailableRoom(bookList,hotelList[i].No,rooms[j].No,checkIn,checkOut))
                    {
                        rooms[j].display();
                    }
                }
            }
        }


        static bool CheckAvailableRoom(List<Book> bookList, string hotelNo,string roomNo, int checkIn, int checkOut)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Book book = bookList[i];
                if (book.HotelNo.Equals(hotelNo)
                    && book.RoomNo.Equals(roomNo)
                    && ((book.CheckIn >= checkIn && book.CheckIn <= checkOut) ||
                        (book.CheckOut >= checkIn && book.CheckOut <= checkOut)))
                {
                    return false;
                }
            }
            return true;
        }
        static void InputBook(List<Book> bookList,List<Cutomer> cutomerList,List<Hotel> hotelList)
        {
            Book book = new Book();
            book.Input(cutomerList, hotelList);
            bookList.Add(book);
        }
        static void Input(List<Hotel> hotelList)
        {
            Console.WriteLine("Nhap so khach san can them: ");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Hotel hotel = new Hotel();
                hotel.Input();
                hotelList.Add(hotel);
                Console.WriteLine("----------");
            }
        }

        static void Display(List<Hotel> hotelList)
        {
            for (int i = 0; i <hotelList.Count ; i++)
            {
                hotelList[i].Display();
                Console.WriteLine("------");
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap thong tin khach san");
            Console.WriteLine("2. Hien thi thong tin khach san");
            Console.WriteLine("3. Dat phong");
            Console.WriteLine("4. Tim phong con trong");
            Console.WriteLine("5. Thong ke doanh thu");
            Console.WriteLine("6. Tim kiem thong tin khach hang");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Lua chon :");



        }
    }
}