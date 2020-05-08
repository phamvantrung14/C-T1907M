using System;
using System.Collections.Generic;

namespace T1907M.Assignment7
{
    public class StudentManager:Student
    {
        List<Student> listStudent = new List<Student>();
        public StudentManager(string id, string name, int age, string address, double gpa) : base(id, name, age, address, gpa)
        {
        }

        public StudentManager()
        {
        }

        public override void Display()
        {
            base.Display();
        }

        public override void Input()
        {
            base.Input();
        }

        public void AddStudent()
        {
            Console.WriteLine("So Student muon them: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student thu "+(i+1)+": ");
                Student st = new Student();
                st.Input();
                listStudent.Add(st);
            }
        }

        public void EditStudent()
        {
            Console.WriteLine("Nhap id muon chinh sua: ");
            string idCode = Console.ReadLine();
            for (int i = 0; i <listStudent.Count; i++)
            {
                if (listStudent[i].Id.Equals(idCode))
                {
                    Console.WriteLine("Nhap Name:");
                    listStudent[i].Name = Console.ReadLine();
                    Console.WriteLine("Nhap Age:");
                    listStudent[i].Age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Address:");
                    listStudent[i].Address = Console.ReadLine();
                    Console.WriteLine("Nhap GPA: ");
                    listStudent[i].Gpa = double.Parse(Console.ReadLine());


                }
            }
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Nhap id muon xoa");
            string idCode = Console.ReadLine();
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (listStudent[i].Id.Equals(idCode))
                {
                    listStudent.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong id: "+idCode);
                }
            }
        }

        public void SortStudentByGpa()
        {
            Console.WriteLine("Nhap GPA de tim kiem: ");
            double gpaCode = double.Parse(Console.ReadLine());
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (listStudent[i].Gpa.Equals(gpaCode))
                {
                    Console.WriteLine("Student thu "+(i+1));
                    listStudent[i].Display();
                    Console.WriteLine("-----------------");
                }
            }
        }
        public void SortStudentByName()
        {
            Console.WriteLine("Nhap Name de tim kiem: ");
            string nameSearch = Console.ReadLine();
            foreach (var VARIABLE in listStudent)
            {
                if (VARIABLE.Name.Equals(nameSearch))
                {
                    VARIABLE.Display();
                    Console.WriteLine("--------------------");
                }
            }
        }

        public void ShowSt()
        {
            Console.WriteLine("Danh sach student: ");
            for (int i = 0; i < listStudent.Count; i++)
            {
                
                Console.WriteLine("Sinh vien thu "+(i+1));
                listStudent[i].Display();
            }
        }
    }
}