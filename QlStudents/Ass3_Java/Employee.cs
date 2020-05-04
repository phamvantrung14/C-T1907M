using System;

namespace QlStudents.Ass3_Java
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;

        public Employee()
        {
        }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
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

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public void ToString()
        {
            Console.WriteLine("Id: "+this.id+", Name: "+this.name+", Salary: "+this.salary);
        }
    }
}