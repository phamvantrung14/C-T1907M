using System;

namespace T1907M.Session3
{
    public class Man:Human,IHuman
    {
        public void Alo()
        {
            throw new NotImplementedException();
        }

        public override void AddFriend()
        {
            throw new NotImplementedException();
        }

        public override void Running()
        {
            Console.WriteLine("Vua chay vua hat....");
        }

        public new void Eat()
        {
            Console.WriteLine("Eating and Sing...");
        }
    }
}