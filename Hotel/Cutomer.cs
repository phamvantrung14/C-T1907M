using System;

namespace Hotel
{
    public class Cutomer
    {
        public string CMTND { get; set; }
        public string Fullname { get; set; }
        public int Old { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Cutomer()
        {
        }

        public void Input()
        {
            Console.WriteLine("Nhap CMTND: ");
            CMTND = Console.ReadLine();
            InputWithoutCMTND();
        }

        public void InputWithoutCMTND()
        {
            Console.WriteLine("Nhap Ho & ten: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap Gioi Tinh: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Nhap Dia chi: ");
            Address = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            Old = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Thong tin KH: (Ho ten: {0}, Tuoi: {1}, CMTND: {2}, Gioi tinh: {3}, Dia chi: {4})"
                ,Fullname,Old,CMTND,Gender,Address);
        }
    }
}