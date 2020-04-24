using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Lap02
{
    public  class Product
    {
        protected int id;
        protected string name;
        protected int qty;
        protected string image;
        protected string desc;
        protected double price;
        protected List<string> gallery;
      
        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product(int id, string name, int qty, string image, string desc, double price, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
            this.price = price;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
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

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }


        public virtual void GetInfo()
        {
            Console.WriteLine("id: "+this.id+" Name: "+this.name+" qty: "+this.qty+" image: "+this.image+" des: "+this.desc);
            
           
        }

        public bool CheckStock()
        {
            if (qty>0)
            {
                return true;
            }

            return false;
        }

        public bool addGallery(string image)
        {
            if (gallery.Count>10)
            {
                Console.WriteLine("So anh vuot qua so luong, can xoa bot truoc khi them.");
                return false;
            }
            gallery.Add(image);
            return true;
        }

        public void DeleteGalery()
        {
            Console.WriteLine("Danh sach anh gallery:");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine(i+". "+gallery[i]);
            }
            Console.WriteLine("Chon anh de xoa: ");
            int stt = Int32.Parse(Console.ReadLine());
            gallery.RemoveAt(stt);
        }
        
    }
}