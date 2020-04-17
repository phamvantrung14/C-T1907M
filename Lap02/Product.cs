using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Lap02
{
    public class Product
    {
        private int id;
        private string name;
        private int qty;
        private string image;
        private string desc;
        List<Product> gallery = new List<Product>();
      
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
        
        public void GetInfo()
        {
            Console.WriteLine("id: "+this.id+" Name: "+this.name+" qty: "+this.qty+" image: "+this.image+" des: "+this.desc);
            Console.WriteLine("----------------------");
           
        }

        public void QtyInfo(int qty)
        {
           
                
                if (qty.Equals(0))
                {
                    Console.WriteLine("hết hàng");
                }
                else
                {
                    Console.WriteLine("Còn hàng");
                }
           
        }

        public void addGallery()
        {
            
        }
    }
}