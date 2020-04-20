using System;

namespace Book
{
    public class AptechBook:Book
    {
        public string language { get; set; }
        public string semester { get; set; }

        public AptechBook()
        {
            
        }

        public AptechBook(string name, string author, string producer, string yearPublish, float price, string language, string semester) 
            : base(name, author, producer, yearPublish, price)
        {
            this.language = language;
            this.semester = semester;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngon ngu: ");
            language = Console.ReadLine();
            Console.WriteLine("Nhap ky hoc: ");
            semester = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            /*Console.WriteLine("Thong tin sach (ten sach :{0}"+
                              "Ten tac gia: {1},"+
                              "Ten nha sacn xuat: {2},"+
                              "nam san xuat: {3}," +
                              "gia ban: {4},"+
                "ngon ngu: {5},"+"ky hoc: {6}",name,author,
                producer,yearPublish,price);*/
            
            Console.WriteLine("Ngon ngu: "+language);
            Console.WriteLine("Hoc ky: "+semester);
            
        }
    }
}