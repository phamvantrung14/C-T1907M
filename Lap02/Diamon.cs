using System;

namespace Lap02
{
    public class Diamon:Product
    {
        private double cara;

       
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("cara: "+cara);
        }

       
        public void Check()
        {
            if (cara.Equals(0))
            {
                //QtyInfo();
                Console.WriteLine("hang gia");
            }
            else
            {
                Console.WriteLine("hang that");
            }
        }
    }
}