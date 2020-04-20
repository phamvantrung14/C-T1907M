using System;

namespace QlStudents
{
    public class Student
    {
        private string studentId { get; set; }
        private string studentName { get; set; }
        private double averageScore { get; set; }
        
        public Student()
        {
        }

        public Student(string studentId, string studentName, double averageScore)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.averageScore = averageScore;
        }

       

        public void display()
        {
            Console.WriteLine("Id: "+this.studentId+" - Name: "+this.studentName+" - Average Score: "+this.averageScore);
        }

        public void inputData()
        {
            Console.WriteLine("Nhap id:");
            this.studentId = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Name:");
            this.studentName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap average score:");
            this.averageScore = Convert.ToDouble(Console.ReadLine());
        }
    }
}