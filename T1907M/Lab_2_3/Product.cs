using System;
using System.Collections.Generic;

namespace T1907M.Lab_2_3
{
    public class Product
    {
        protected int id;
        protected string name;
        protected uint qty;
        protected string image;
        protected string desc;
        protected double price;
        protected List<string> gallery;

        //contructor để tự động chạy ngay tại thời điểm tạo đối tượng
        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product( int id, string name, uint qty, string image, string desc,double price, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.price = price;
            this.gallery = gallery;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            //set => gallery = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public string this[int index]
        {
            get { return gallery[index];}
            set { gallery[index] = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine("ID: "+this.id+" Name: "+this.name+
                              " qty: "+this.qty+" Price: "+this.price);
        }

        public virtual void Display()
        {
            Console.WriteLine("Name "+this.name+" - qty: "+this.qty);
        }

        public bool CheckStock()
        {
            /*if (qty>0)
            {
                Console.WriteLine("Con hang");
                return;
            }
            Console.WriteLine("het hang");*/
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count>=10)
            {
                Console.WriteLine("Anh da vuot qua so luong, can xoa bot di truoc khi them");
                return false;
            }
            /*Console.WriteLine("Nhap link anh:");
            string new_image = Console.ReadLine();
            gallery.Add(new_image);*/
            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("danh sach anh:");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine(i+"."+gallery[i]);
            }
            Console.WriteLine("Chon anh de xoa");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number<gallery.Count && number>=0)
            {
                gallery.RemoveAt(number);
                return true;
            }
            return false;
        }

    }
}