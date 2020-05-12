using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Tiger tiger = new Tiger();
            
            tiger.SetMe("tiger",100);
            lion.SetMe("lion",200);
            
            tiger.Show();
            lion.Show();
        }
    }
}