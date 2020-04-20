using System;
using System.Collections.Generic;

namespace Book
{
    class Test
    {
        static void Main(string[] args)
        {
            List<AptechBook> aptechBooks = new List<AptechBook>();
            int choose;
            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Input(aptechBooks);
                        break;
                    case 2:
                        Display(aptechBooks);
                        break;
                    case 3:
                        Sort(aptechBooks);
                        break;
                    case 4:
                        SearchingByBookName(aptechBooks);
                        break;
                    case 5:
                        SearchingByBookAuthor(aptechBooks);
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                    default:
                        Console.WriteLine("lua chon sai");
                        break;
                }
            } while (choose != 6);
        }

        static void Input(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap so sach can them :");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AptechBook book =new AptechBook();
                book.Input();
                aptechBooks.Add(book);
            }
        }

        static void Display(List<AptechBook> aptechBooks)
        {
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                aptechBooks[i].Display();
            }
        }

        static void SearchingByBookAuthor(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            String seaching = Console.ReadLine();
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].author.Equals(seaching))
                {
                    aptechBooks[i].Display();
                }
            }
        }
        static void SearchingByBookName(List<AptechBook> aptechBooks)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            String seaching = Console.ReadLine();
            for (int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].name.Equals(seaching))
                {
                    aptechBooks[i].Display();
                }
            }
        }
        static void Sort(List<AptechBook> aptechBooks)
        {
            aptechBooks.Sort((AptechBook o1, AptechBook o2) =>
            {
                return string.Compare(o1.yearPublish, o2.yearPublish, StringComparison.OrdinalIgnoreCase);
                
            });
            Display(aptechBooks);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap thong tin cuon sach cua Aptech");
            Console.WriteLine("2. Hien thi thong tin vua nhap");
            Console.WriteLine("3. Sap xep thong tin giam dan theo nam xuat ban va hien thi");
            Console.WriteLine("4. Tim kiem theo ten sach");
            Console.WriteLine("5. Tim kiem theo ten tac gia");
            Console.WriteLine("6. Thoat");
            Console.WriteLine("Lua chon");

        }
    }
}