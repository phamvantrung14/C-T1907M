using System;

namespace Lap02
{
    public class Fashion:Product
    {
        private string color;
        private string size;

        

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Color: "+color+" -Size: "+size);
        }

       
    }
}