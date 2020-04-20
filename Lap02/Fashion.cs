using System;

namespace Lap02
{
    public class Fashion:Product
    {
        private string color;
        private string size;

        public Fashion(int id, string name, int qty, string image, string desc, string color, string size) : base(id, name, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Color: "+color+" -Size: "+size);
        }

        public override void QtyInfo()
        {
            base.QtyInfo();
            
        }
    }
}