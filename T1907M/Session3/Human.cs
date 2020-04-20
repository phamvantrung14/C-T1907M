using System;

namespace T1907M.Session3
{
    public abstract class Human
    {
        protected string name;
        protected string age;

        public Human()
        {
        }

        public Human(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void AddFriend();

        public virtual void Running()
        {
            Console.WriteLine("Run...");
        }

        public void Eat()
        {
            Console.WriteLine("...");
        }
    }
}