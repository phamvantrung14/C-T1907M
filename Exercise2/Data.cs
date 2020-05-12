using System;
using System.Security.Cryptography;

namespace Exercise2
{
    public class Data
    {
        private string name;
        private int weight;


        public Data()
        {
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: "+this.name+", Weight "+this.weight);
        }

        public virtual void SetMe(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}