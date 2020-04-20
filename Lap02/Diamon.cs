using System;

namespace Lap02
{
    public class Diamon:Product
    {
        private double cara;

        public Diamon(int id, string name, int qty, string image, string desc, double cara) : base(id, name, qty, image, desc)
        {
            this.cara = cara;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("cara: "+cara);
        }

        public override void QtyInfo()
        {
            base.QtyInfo();
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