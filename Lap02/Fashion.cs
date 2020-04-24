using System;
using System.Collections.Generic;

namespace Lap02
{
    public class Fashion:Product
    {
        private string color;
        private string size;

        public Fashion(int id, string name, int qty, string image, string desc,double price, List<string> gallery, string color, string size) : base(id, name, qty, image, desc,price, gallery)
        {
            this.color = color;
            this.size = size;
        }

        public bool CheckSize(string size)
        {
            if (this.size.Equals(size) && qty>0)
            {
                Console.WriteLine("San pham: "+this.name+" size: "+this.size +" Con hang");
                return true;
            }
            Console.WriteLine("Rat tiec khong co size cua ban");
            return false;
        }

        public bool CheckColor(string color)
        {
            if (this.color.Equals(color) && qty>0)
            {
                Console.WriteLine("San pham: "+this.name+" mau: "+this.size +" Con hang");
                return true;
            }
            Console.WriteLine("rat tiec khong co size cua ban");
            return false;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Color: "+color+" -Size: "+size);
        }

       
    }
}