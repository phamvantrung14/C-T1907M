using System;

namespace T1907M.Session3
{
    public class Human
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

        public void running()
        {
            Console.WriteLine("Run...");
        }
    }
}