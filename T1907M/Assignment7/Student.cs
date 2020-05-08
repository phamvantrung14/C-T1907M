using System;

namespace T1907M.Assignment7
{
    public class Student
    {
        private string id;
        private string name;
        private int age;
        private string address;
        private double gpa;

        public Student()
        {
        }

        public Student(string id, string name, int age, string address, double gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public string Id
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

        public string Address
        {
            get => address;
            set => address = value;
        }

        public double Gpa
        {
            get => gpa;
            set => gpa = value;
        }

        public virtual void Display()
        {
            Console.WriteLine("Id: "+this.id+" - Name: "+this.name+" - Age: "+this.age+
                              " - Address: "+this.Address+" - Gpb: "+this.gpa);
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap Id:");
            this.id = Console.ReadLine();
            Console.WriteLine("Nhap Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhap Age: ");
            this.age = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap Address: ");
            this.Address = Console.ReadLine();
            Console.WriteLine("Nhap Gpa: ");
            this.gpa = double.Parse(Console.ReadLine());
        }
    }
}