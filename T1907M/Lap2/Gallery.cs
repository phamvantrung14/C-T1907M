using System;
using System.Collections.Generic;

namespace T1907M.Lap2
{
    public class Gallery
    {
        private string image;
        List<Gallery> gallery = new List<Gallery>();

        public Gallery()
        {
        }

        public void Input()
        {
            image = Console.ReadLine();
        }
        public void AddGallery()
        {
            Console.WriteLine("So anh muon nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 10;
            if (n <= 10 && gallery.Count<i)
            {
                for (int j = 0; j < n; j++)
                {
                    Gallery gr = new Gallery();
                    Console.WriteLine("Nhap ten anh thu " + (j + 1) + ": ");
                    gr.Input();
                    if (gallery.Count<i)
                    {
                        gallery.Add(gr);
                    }
                    else
                    {
                        Console.WriteLine("So anh da du. vui long xoa bot di");
                    }
                    

                }
            }
            else
            {
                Console.WriteLine("Chi duoc nhap duoi 10 cho 1 san pham.");
            }
        }

        public void Display()
        {
            Console.WriteLine(this.image);
        }
        public void ShowGallery1()
        {
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine("Anh so " + (i + 1));
                gallery[i].Display();
            }
        }

        public void ShowGallery2()
        {
            foreach (var VARIABLE in gallery)
            {
                VARIABLE.Display();
            }
        }

        public void RemoveGallery()
        {
            Console.WriteLine("Nhap thu tu anh muon xoa");
            int n = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < gallery.Count; i++)
            {
                if (i ==n)
                {
                    gallery.RemoveAt(n);
                    Console.WriteLine("xoa anh thanh cong");
                }
                
                
                
            }
        }
    }
}