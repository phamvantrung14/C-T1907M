using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace T1907M.Lap2
{
    public class Product
    {
        private string id;
        private string name;
        private double price;
        private int qty;
        private string image;
        private string desc;
        //private List<string> gallery = new List<string>();
        public List<Product> ProductList = new List<Product>();
        Gallery gallery = new Gallery();
        public Product()
        {
        }

        public Product(string id, string name, double price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            
        }

        public void InputData()
        {
            Console.WriteLine("Nhap ID: ");
            this.id =  Console.ReadLine();
            Console.WriteLine("Nhap Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhap price: ");
            this.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Quantity: ");
            this.qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap image: ");
            this.image = Console.ReadLine();
            Console.WriteLine("Nhap Desc: ");
            this.desc = Console.ReadLine();
            gallery.AddGallery();
            
        }

        public void AddData()
        {
            Console.WriteLine("So san Product muon them: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
             Product pd = new Product();
             pd.InputData();
             ProductList.Add(pd);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Id: "+this.id+" -Name: "+this.name+" -Price: "
            +this.price+" -Qty: "+this.qty+" -Image: "+this.image+" -Desc: "+this.desc);
           gallery.ShowGallery1();
        }

        public void GetData()
        {
            Console.WriteLine("Danh sach Product: ");
            foreach (var VARIABLE in ProductList)
            {
                VARIABLE.ShowInfo();
                Console.WriteLine("-----------------------");
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Nhap ten san pham muon xoa: ");
            string NameProduct = Console.ReadLine();
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].name.Equals(NameProduct))
                {
                    ProductList.RemoveAt(i);
                }
            }
        }

        public void CheckProduct()
        {
            Console.WriteLine("Nhap ten hang de kiem tra: ");
            string NameProduct = Console.ReadLine();
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].name.Equals(NameProduct))
                {
                    if (ProductList[i].qty.Equals(0))
                    {
                        Console.WriteLine("het hang");
                    }
                    else
                    {
                        Console.WriteLine("hang con, quantity: "+ProductList[i].qty);
                    }
                }
            }
        }

        
        public void AddGallery()
        {
            Console.WriteLine("Nhap anh cho san pham:");
            string NameProduct = Console.ReadLine();
            int n = 10;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].name.Equals(NameProduct))
                {
                   
                   ProductList[i].gallery.AddGallery();
                    
                    
                }
            }
           
        }

        public void DeleteGallery()
        {
            Console.WriteLine("nhap ten san pham: ");
            string NamePd = Console.ReadLine();
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].name.Equals(NamePd))
                {
                    gallery.RemoveGallery();
                }
            }
            
        }

       
        
        
    }
}