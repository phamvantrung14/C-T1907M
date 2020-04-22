using System.Collections.Generic;

namespace T1907M.Lab_2_3
{
    public class Diamon:Product
    {
        private uint cara;


        public Diamon(int id, string name, uint qty, string image, string desc,double price, List<string> gallery, uint cara)
            : base(id, name, qty, image, desc,price, gallery)
        {
            this.cara = cara;
        }

        public bool IsReal()
        {
            // cong thuc kiem tra nao do
            if (cara > 5) return true;
            return false;
        }
    }
}