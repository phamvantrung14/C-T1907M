using System;
using System.Collections.Generic;

namespace Lap02_1
{
    public class Product
    {
        private int id;
        private string name;
        private int qty;
        private string image;
        private string desc;
        private List<string> gallery;
        private string img;
        public Product()
        {
        }
    
        public Product(int id, string name, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public void InputGallery()
        {
            Console.WriteLine("So anh muon nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<=10)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("anh thu "+(i+1));
                    img = Convert.ToString(Console.ReadLine());
                    gallery.Add(image);
                }
            }
            else
            {
                Console.WriteLine("So anh khong hop le");
            }
           
        }

        

        public void showImg()
        {
            foreach (var VARIABLE in gallery)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        public void InputData()
        {
            Console.WriteLine("Nhap id: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap name: ");
            this.name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap qty");
            this.qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap image: ");
            this.image = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap desc: ");
            this.desc = Convert.ToString(Console.ReadLine());
           
        }

        public void ShowProduct()
        {
            Console.WriteLine("Id: "+this.id+" - Name: "+this.name+" -qty: "+this.qty+" -image: "+this.image+" - desc: "+this.desc);
            
        }

    }
}