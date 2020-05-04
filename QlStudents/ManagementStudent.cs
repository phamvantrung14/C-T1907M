using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace QlStudents
{
    public class ManagementStudent:Student
    {
        List<Student> listSt = new List<Student>();

        public void AddData()
        {
            
            Console.WriteLine("So Student can nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student st = new Student();
                st.inputData();
                listSt.Add(st);
            }
        }

        public void RemoveData()
        {
            Console.WriteLine("Nhạp thu tu can xoa:");
            int keyword = Convert.ToInt32(Console.ReadLine());
            listSt.RemoveAt(keyword);
           
        }

        public void ShowData()
        {
            //Student st = new Student();
            Console.WriteLine("Danh sach Student: ");
            foreach (var VARIABLE in listSt)
            {
                VARIABLE.display();
                Console.WriteLine("---------------");
            }
        }

        public void SapXep()
        {
            for (int i = 0; i < listSt.Count-1; i++)
            {
                for (int j = i+1; j < listSt.Count; j++)
                {
                    if (listSt[i].averageScore<listSt[j].averageScore)
                    {
                        Student st = listSt[i];
                        listSt.ToImmutableSortedSet();
                        listSt[j] = st;

                    }
                }
            }
        }

        public void SearchingByName()
        {
            Console.WriteLine("nhap tu can tim kiem");
            String seaching = Console.ReadLine();

            foreach (var VARIABLE in listSt)
            {
                if (VARIABLE.studentName.Equals(seaching))
                {
                    VARIABLE.display();
                }
            }
        }
        
    }
}