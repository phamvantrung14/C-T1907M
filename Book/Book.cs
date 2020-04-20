using System;

namespace Book
{
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public string producer { get; set; }
        public string yearPublish { get; set; }
        public float price { get; set; }

        public Book()
        {
        }

        public Book(string name, string author, string producer, string yearPublish, float price)
        {
            this.name = name;
            this.author = author;
            this.producer = producer;
            this.yearPublish = yearPublish;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ten sach: ");
            name = Console.ReadLine();
            Console.WriteLine("Ten tac gia: ");
            author = Console.ReadLine();
            Console.WriteLine("Ten nha san xuat: ");
            producer = Console.ReadLine();
            Console.WriteLine("Nam san xuat: ");
            yearPublish = Console.ReadLine();
            Console.WriteLine("Gia ban: ");
            price = float.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            /*Console.WriteLine("Thong tin sach (ten sach :{0}"+
                              "Ten tac gia: {1},"+
                              "Ten nha sacn xuat: {2},"+
                              "nam san xuat: {3}," +
                              "gia ban: {4})",name,author,
                producer,yearPublish,price);*/
            Console.WriteLine("--------Thong tin sach--------");
            Console.WriteLine("Ten sach: "+name);
            Console.WriteLine("Ten tac gia:"+author);
            Console.WriteLine("Ten nha sach:"+producer);
            Console.WriteLine("Nam san xuat:"+yearPublish);
            Console.WriteLine("Gia ban:"+price);
        }
    }
}