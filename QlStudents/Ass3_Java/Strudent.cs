using System;

namespace QlStudents.Ass3_Java
{
    public class Strudent
    {
        private int id;
        private string name;
        private int age;

        public Strudent()
        {
        }

        public Strudent(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public void ToString()
        {
            Console.WriteLine("Id: "+this.id+", Name: "+this.name+", Age: "+this.age);
        }
    }
}